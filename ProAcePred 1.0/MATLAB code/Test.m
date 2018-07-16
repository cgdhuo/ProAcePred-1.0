clear
clc
%Test program
% such as main function
% [AllData,rr,cc]=PredictmainDa(proteinsequence,Specificity),'proteinsequence' is 
% protein sequence (protein sequence must fasta format, such as ">|protein name|"),
% 'Specificity' is threshold value, if prediction probable value greater
% than this threshold value, it suggested that this protein sequence may be
% occurrence acetylation, otherwise,it suggested that this protein sequence
% is not occurence acetylation.'AllData' is output prediction result about
% this model, 'rr' and 'cc' represent [rr,cc]=size(AllData)
%% E.coli
%If you want prediction E.coli acetylation site, you can choice this program.
filepath=('C:\Users\Administrator\Desktop\protein_fasta.txt');% you can copy yourself file path
file=textread(filepath,'%s','delimiter','\n','whitespace','');
Specificity=0.5;  %you can reparametrization
[AllData,rr,cc]=PredictmainDa(file,Specificity);% main function
%%
%If you want prediction C.glutamicum acetylation site, you can choice this program.
filepath=('C:\Users\Administrator\Desktop\protein_fasta.txt');% you can copy yourself file path
file=textread(filepath,'%s','delimiter','\n','whitespace','');
Specificity=0.5;%you can reparametrization
[AllData,rr,cc]=PredictmainGu(file,Specificity);% main function
%% M.tuberculosis
%If you want prediction M.tuberculosis acetylation site, you can choice this program.
filepath=('C:\Users\Administrator\Desktop\protein_fasta.txt');% you can copy yourself file path
file=textread(filepath,'%s','delimiter','\n','whitespace','');
Specificity=0.5;%you can reparametrization
[AllData,rr,cc]=PredictmainJie(file,Specificity);% main function
%% B.subtilis
%If you want prediction B.subtilis acetylation site, you can choice this program.
filepath=('C:\Users\Administrator\Desktop\protein_fasta.txt');% you can copy yourself file path
file=textread(filepath,'%s','delimiter','\n','whitespace','');
Specificity=0.5;%you can reparametrization
[AllData,rr,cc]=PredictmainKu(file,Specificity);% main function
%% S.typhimurium
%If you want prediction S.typhimurium acetylation site, you can choice this program.
filepath=('C:\Users\Administrator\Desktop\protein_fasta.txt');% you can copy yourself file path
file=textread(filepath,'%s','delimiter','\n','whitespace','');
Specificity=0.5;%you can reparametrization
[AllData,rr,cc]=PredictmainSha(file,Specificity);% main function
%% G.kaustophilus
%If you want prediction G.kaustophilus acetylation site, you can choice this program.
filepath=('C:\Users\Administrator\Desktop\protein_fasta.txt');% you can copy yourself file path
file=textread(filepath,'%s','delimiter','\n','whitespace','');
Specificity=0.5;%you can reparametrization
[AllData,rr,cc]=PredictmainShi(file,Specificity);% main function