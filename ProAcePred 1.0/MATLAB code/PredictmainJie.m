function [AllData,rr,cc]=PredictmainJie(proteinsequence,Specificity)
proteinsequence=char(proteinsequence);
R=size(proteinsequence,1);
filepath='C:\DataSet\PAPred\jieheganjun';
nn=0;
LL=13;  %sequence fragment size
ww1=[];AllData=[];
for jj=1:R
    if (proteinsequence(jj,1)=='>')
        nn=nn+1;
        ww1(nn)=jj;
    end
end
for ii=1:nn
    clear estim;
    clear X;clear Data;
    if ii<nn
        protein=proteinsequence(ww1(ii):ww1(ii+1)-1,:);
    else
        protein=proteinsequence(ww1(nn):R,:);
    end
    value=CheckSequence(protein);
    if value==0
        continue;
    end
    [Fragment,SiteNumber,name]=ExtractFragment(protein);
    if size(Fragment,1)==0
        Data=[{}];
        AllData=[AllData;Data];
        rr=0;cc=0;
        continue;
    end
    Fragment1=IG(Fragment,filepath,LL);
    string=Fragment1;
    sequence6=K_space(string,LL);
    sequence5=PWAA(string,LL);
    sequence4=KNN(string,filepath,LL);
    sequence3=EBGW(string,LL);
    sequence2=AASA(string,LL);
    sequence1=AAC(string,LL);
    sequen=[sequence1 sequence2 sequence3 sequence4 sequence5 sequence6];
    FeSq2svm(sequen,filepath);
    filesvm=('D:');
    load ([filepath '\model.mat']);
    prob_estim1=ASVM([filepath '\svm.txt'],filepath,filesvm,model);
    delete([filepath,'\svm.txt']);
    r1=size(prob_estim1,1);
    mm=0;X=[];estim=[{}];
   for i1=1:r1
        if prob_estim1(i1,1)>=Specificity
            mm=mm+1;
            X(mm)=i1;
        end
          estim(i1,:)={num2str(prob_estim1(i1,1))};
   end
     if mm==0
         Data=[{}];
         AllData=[AllData;Data];
         rr=0;cc=0;
     else
       Data=[name,SiteNumber,cellstr(Fragment),estim];
       AllData=[AllData;Data(X,1:4)];
     end
end
[rr,cc]=size(AllData);
end
%SVM测试函数
function prob_estim=ASVM(Inname,filepath,filesvm,model)
cmd1=['C:\DataSet\PAPred\svm-scale -r ' ([filepath,'\TrainRange.txt ']) Inname ' >' ([filesvm,'\TestScale.txt']) ''];
system(cmd1);
[test_label_vector,test_instance_matrix]=libsvmread([filesvm,'\TestScale.txt']);
[~,~,prob_estim]=svmpredict(test_label_vector,test_instance_matrix,model,'-b 1');
delete([filesvm,'\TestScale.txt']);
end
%%%% 检查序列
function value=CheckSequence(string)
string=char(string);
[r,c]=size(string);
Lh=0;
L=10;   %上游窗口大小
for i=1:c
    if (string(2,i)~=' ')
        Lh=Lh+1;
    end
end
string1=string(2:end,1:Lh);
[Ls,La]=size(string1);
len=Ls*La;
string2=string1';
strings=reshape(string2,1,len);
strings=deblank(strings);            %%%%%每一条序列的总长度
n=size(strings,2);
if size(findstr(strings,'X'),1)==1||size(findstr(strings,'B'),1)==1||size(findstr(strings,'Z'),1)==1||size(findstr(strings,'J'),1)==1
    value=0;
else
    value=1;
end
end
%截取序列片段
function [Fragment,SiteNumber,name]=ExtractFragment(string)
string=char(string);
c=size(string,2);
Lh=0;
L=10;%序列片段上游长度
for i=1:c
    if (double(string(2,i))>=65&&double(string(2,i))<=90)
        Lh=Lh+1;
    end
end
string1=string(2:end,1:Lh);
[Ls,La]=size(string1);
len=Ls*La;
string2=string1';
strings=reshape(string2,1,len);
strings=deblank(strings);            %%%%%每一条序列的总长度
n=size(strings,2);                                %%%%%每一条序列的总长度
m=0;                                 %%%%%要确定位点的字母的个数
for i=1:n
    if (strings(i)=='K')
        m=m+1;
    end
end
t=0;
for i=1:n
    if (strings(i)=='K')
        t=t+1;
        s(t)=i;     %%%%%位点字母在总序列中的位置
    end
end
str=zeros(m,2*L+1);
str=char(str);     %%%创建字符矩阵，用于存放截取的全部有效的序列片段
for i=1:m
    %%%%%  str(i,:)=strings(s(i)-L:s(i)+L);
    if ((s(i)-L)<1&&s(i)+L<=n)
        cha1=L-s(i);
        str(i,1:cha1+1)='O';
        str(i,cha1+2:2*L+1)=strings(1:s(i)+L);
    elseif ((s(i)-L)>=1&&(s(i)+L)<=n)
        str(i,:)=strings(s(i)-L:s(i)+L);
    elseif ((s(i)-L)>=1&&(s(i)+L)>n)
        str(i,1:L+n+1-s(i))=strings(s(i)-L:n);
        str(i,L+n+2-s(i):2*L+1)='O';
    elseif ((s(i)-L)<1&&(s(i)+L)>n)
        str(i,1:L-s(i)+1)='O';
        str(i,L-s(i)+2:L-s(i)+1+n)=strings(1:n);
        str(i,L-s(i)+2+n:2*L+1)='O';
    end
end
r=size(str,1);
p=findstr(string(1,:),'|');
if r>0
    for i=1:r
        Fragment(i,:)=deblank(str(i,:));
        name(i,:)={string(1,p(1)+1:p(2)-1)};
        SiteNumber(i,:)={num2str(s(i))};
    end
elseif r==0
    Fragment='';
    SiteNumber={''};
    name={''};
end
end
% extract IG position residues
function sequence=IG(fragment,filepath,K)
file=char(fragment);
h=size(file,1);
file1=xlsread([filepath,'\IG.xlsx']);
text=cell(1,1);
for i=1:K
    p(1,i)=file1(2,i);
end
P=sort(p);
for i=1:h
    for j=1:K
      seq(j)=file(i,P(j));
    end
    text{i,1}=seq;
end
sequence=char(text);
end
%%
%训练特征值
%PWAA
function PWAA=PWAA(strings,LL)
L=(LL-1)/2;
r=size(strings,1);
ucidata=zeros(r,21);
AAS='ACDEFGHIKLMNPQRSTVWYO';
for j=1:r
    for k=1:21
        pos=findstr(strings(j,:),AAS(k));
        h1=size(pos,2);
        c=zeros(1,h1);
        for i1=1:h1
            if pos(i1)>=1&&pos(i1)<=L
               p(i1)=pos(i1)-L-1;
            elseif pos(i1)>L&&pos(i1)<=2*L+1
                p(i1)=pos(i1)-L-1;
            end
        end
        for i1=1:h1
            if p(i1)>=-L&&p(i1)<=L
                c(i1)=p(i1)+abs(p(i1))/L;
            end
        end
        ucidata(j,k)=sum(c)/(L*(L+1));
        clear pos;clear h1;clear p;clear c;
    end
end
PWAA=ucidata;
end
%KNN
function KNN=KNN(test,comparisonfile,L)
AAS='CSTPAGNDEQHRKMILVFYWO';
matrixpath='C:\DataSet\PAPred\blosum62.xls';
[N,file1,raw]=xlsread(matrixpath);
matrixmax=max(max(N));matrixmin=min(min(N));
test=char(test); r1=size(test,1);
comparison1=textread([comparisonfile,'\bjj.txt'],'%s','delimiter','\n','whitespace','');
comparison=char(comparison1); rcomparison=size(comparison,1); r2=rcomparison/2;
K(1)=2;K(2)=4;K(3)=8;K(4)=16;K(5)=32;
% K(6)=fix(0.0015*r2);K(7)=fix(0.00125*r2);
KNUM=5;   %K的个数为5
for i=1:r1
    for j=1:r2
        for k=1:L
         line(k)=findstr(AAS,test(i,k)); 
         row(k)=findstr(AAS,comparison(2*j,k)); 
         matrixscores(k)=N(line(k),row(k));
         sim(k)=(matrixscores(k)-matrixmin)/(matrixmax-matrixmin);
        end
        Dist(j)=1-sum(sim)/L;
    end
    [sortDist,index]=sort(Dist);
    positivenum(1:KNUM)=0;  %%K的个数为5
    for jj=1:KNUM       %%K的个数为5
        pos=index(1:K(jj));
        posnum=size(pos,2);
        for ii=1:posnum
            if pos(ii)<=r2/2;
               positivenum(jj)=positivenum(jj)+1;
            end
        end
        KNNScore(i,jj)=positivenum(jj)/K(jj);
    end
end
KNN=KNNScore;
end
%K_space
function K_space=K_space(strings,n)
AAs='ACDEFGHIKLMNPQRSTVWYO';
p=0;
for a=1:21
    for b=1:21
        p=p+1;
        pair(p,:)=[AAs(a),AAs(b)];
    end
end        
[r,c]=size(strings);
str0=zeros(r,441);
frequency(r,p)=zeros();
for k=0;
for t=1:r
T=0;
for ii=1:n-k-1
    T=T+1;
    AApair(T,:)=[strings(t,ii),strings(t,ii+k+1)];
    for jj=1:p
        if AApair(T,:)==pair(jj,:)
        frequency(t,jj)=frequency(t,jj)+1;
        end
    end
end
end
str0(:,(441*k+1:441*(k+1)))=frequency;
frequency(:,:)=0;
AApair=[];
end
K_space=str0;
end
%EBGW
function EBGW=EBGW(strings,L)
r=size(strings,1);
%AAS='ACDEFGHIKLMNPQRSTVWYO';
C1='AFGILMPVW';
C2='CNQSTY';
C3='HKR';
C4='DE';
ucidata=zeros(r,3*L);
for i=1:r
    for j=1:L
        if size(findstr(C1,strings(i,j)),2)==1||size(findstr(C2,strings(i,j)),2)==1
            ucidata(i,j)=1;
        elseif size(findstr(C3,strings(i,j)),2)==1||size(findstr(C4,strings(i,j)),2)==1
            ucidata(i,j)=0;
        else
            ucidata(i,j)=0;
        end
    end
end
for i=1:r
    for j=1:L
        if size(findstr(C1,strings(i,j)),2)==1||size(findstr(C3,strings(i,j)),2)==1
            ucidata(i,j+L)=1;
        elseif size(findstr(C2,strings(i,j)),2)==1||size(findstr(C4,strings(i,j)),2)==1
            ucidata(i,j+L)=0;
        else
            ucidata(i,j+L)=0;
        end
    end
end
for i=1:r
    for j=1:L
        if size(findstr(C1,strings(i,j)),2)==1||size(findstr(C4,strings(i,j)),2)==1
            ucidata(i,j+2*L)=1;
        elseif size(findstr(C2,strings(i,j)),2)==1||size(findstr(C3,strings(i,j)),2)==1
            ucidata(i,j+2*L)=0;
        else
            ucidata(i,j+2*L)=0;
        end
    end
end
[ur,uc]=size(ucidata);
k1=5;
x=zeros(ur,3*k1);
for i1=1:ur
    for j1=1:k1
        x(i1,j1)=sum(ucidata(i1,1:floor(L*j1/k1)))/floor(L*j1/k1);
        x(i1,j1+k1)=sum(ucidata(i1,L+1:L+floor(L*j1/k1)))/floor(L*j1/k1);
        x(i1,j1+2*k1)=sum(ucidata(i1,2*L+1:2*L+floor(L*j1/k1)))/floor(L*j1/k1);
    end
end
EBGW=x;
end
%AASA
function AASA=AASA(strings,L)
filepath1=('C:\DataSet\PAPred\lhxz.xls');
[N,T,raw]=xlsread(filepath1);
[r,s]=size(N);

AAS='ARNDCQEGHILKMFPSTWYV';
h1=size(strings,1);
for i=127
    for j=1:h1
        for k=1:L
            if strings(j,k)~='O'
              p(k)=findstr(AAS,strings(j,k));
              w(j,k)=N(i,p(k));
            else
              w(j,k)=0;
            end
        end
    end
end
AASA=w;
end
%AAC
function AAC=AAC(string,L)

R=size(string,1);
string1(1:R,1:21)=zeros();
string2='ACDEFGHIKLMNPQRSTVWYO';
string2=char(string2);
[r,c]=size(string2);
for j=1:c
for k=1:R
g(j)=length(find(string(k,:)==string2(j)));
string1(k,j)=g(j);
ucidata=string1(:,:)/L;
end
end
AAC=ucidata;
end
%%
%提取优化后的特征转SVM格式
function FeSq2svm(file1,filepa)
filepath=[filepa,'\zyl.xlsx'];
file=xlsread(filepath);
h=size(file,1);
n=0;
for i=1:h
    if isnan(file(i,1))
        continue;
    else
        n=n+1;
    string(:,n)=file1(:,file(i,1));
    end
end
clear h;
[h,l]=size(string);
%str=zeros(h,l);
str=string(1:h,1:l);
str(1:h,l+1)=1;
%str(h/2+1:h,l+1)=-1;
[ucir,ucic]=size(str);
filename=[filepa,'\svm.txt'];
fid = fopen(filename,'wt');
for j = 1 : ucir
    fprintf(fid, '%s', num2str(str(j, ucic)));
    for k = 1 : ucic-1  
        fprintf(fid,' %s:%s', num2str(k), num2str(str(j, k)));
    end
    fprintf(fid,'\n');
end
fclose(fid);
end