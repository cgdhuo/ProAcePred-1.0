/*
* MATLAB Compiler: 4.13 (R2010a)
* Date: Sun Jun 24 09:28:02 2018
* Arguments: "-B" "macro_default" "-W"
* "dotnet:PredictmainSha,PredictmainShamodel,0.0,private" "-T" "link:lib" "-d"
* "C:\DataSet\PAPred\dll\PredictmainSha\src" "-w" "enable:specified_file_mismatch" "-w"
* "enable:repeated_file" "-w" "enable:switch_ignored" "-w" "enable:missing_lib_sentinel"
* "-w" "enable:demo_license" "-v"
* "class{PredictmainShamodel:F:\matlabÉúÎï³ÌÐòÎÄ¼þ\ÐÂÊµÑé¶þ\libsvmread.mexw64,F:\matlabÉúÎ
* ï³ÌÐòÎÄ¼þ\ÐÂÊµÑé¶þ\libsvmwrite.mexw64,F:\matlabÉúÎï³ÌÐòÎÄ¼þ\ÐÂÊµÑé¶þ\PredictmainSha.m,F:
* \matlabÉúÎï³ÌÐòÎÄ¼þ\ÐÂÊµÑé¶þ\svmpredict.mexw64,F:\matlabÉúÎï³ÌÐòÎÄ¼þ\ÐÂÊµÑé¶þ\svmtrain.m
* exw64}" 
*/
using System;
using System.Reflection;
using System.IO;
using MathWorks.MATLAB.NET.Arrays;
using MathWorks.MATLAB.NET.Utility;
using MathWorks.MATLAB.NET.ComponentData;

#if SHARED
[assembly: System.Reflection.AssemblyKeyFile(@"")]
#endif

namespace PredictmainSha
{
  /// <summary>
  /// The PredictmainShamodel class provides a CLS compliant, MWArray interface to the
  /// M-functions contained in the files:
  /// <newpara></newpara>
  /// F:\matlabÉúÎï³ÌÐòÎÄ¼þ\ÐÂÊµÑé¶þ\libsvmread.mexw64
  /// <newpara></newpara>
  /// F:\matlabÉúÎï³ÌÐòÎÄ¼þ\ÐÂÊµÑé¶þ\libsvmwrite.mexw64
  /// <newpara></newpara>
  /// F:\matlabÉúÎï³ÌÐòÎÄ¼þ\ÐÂÊµÑé¶þ\PredictmainSha.m
  /// <newpara></newpara>
  /// F:\matlabÉúÎï³ÌÐòÎÄ¼þ\ÐÂÊµÑé¶þ\svmpredict.mexw64
  /// <newpara></newpara>
  /// F:\matlabÉúÎï³ÌÐòÎÄ¼þ\ÐÂÊµÑé¶þ\svmtrain.mexw64
  /// <newpara></newpara>
  /// deployprint.m
  /// <newpara></newpara>
  /// printdlg.m
  /// </summary>
  /// <remarks>
  /// @Version 0.0
  /// </remarks>
  public class PredictmainShamodel : IDisposable
  {
    #region Constructors

    /// <summary internal= "true">
    /// The static constructor instantiates and initializes the MATLAB Compiler Runtime
    /// instance.
    /// </summary>
    static PredictmainShamodel()
    {
      if (MWMCR.MCRAppInitialized)
      {
        Assembly assembly= Assembly.GetExecutingAssembly();

        string ctfFilePath= assembly.Location;

        int lastDelimiter= ctfFilePath.LastIndexOf(@"\");

        ctfFilePath= ctfFilePath.Remove(lastDelimiter, (ctfFilePath.Length - lastDelimiter));

        string ctfFileName = MCRComponentState.MCC_PredictmainSha_name_data + ".ctf";

        Stream embeddedCtfStream = null;

        String[] resourceStrings = assembly.GetManifestResourceNames();

        foreach (String name in resourceStrings)
        {
          if (name.Contains(ctfFileName))
          {
            embeddedCtfStream = assembly.GetManifestResourceStream(name);
            break;
          }
        }
        mcr= new MWMCR(MCRComponentState.MCC_PredictmainSha_name_data,
                       MCRComponentState.MCC_PredictmainSha_root_data,
                       MCRComponentState.MCC_PredictmainSha_public_data,
                       MCRComponentState.MCC_PredictmainSha_session_data,
                       MCRComponentState.MCC_PredictmainSha_matlabpath_data,
                       MCRComponentState.MCC_PredictmainSha_classpath_data,
                       MCRComponentState.MCC_PredictmainSha_libpath_data,
                       MCRComponentState.MCC_PredictmainSha_mcr_application_options,
                       MCRComponentState.MCC_PredictmainSha_mcr_runtime_options,
                       MCRComponentState.MCC_PredictmainSha_mcr_pref_dir,
                       MCRComponentState.MCC_PredictmainSha_set_warning_state,
                       ctfFilePath, embeddedCtfStream, true);
      }
      else
      {
        throw new ApplicationException("MWArray assembly could not be initialized");
      }
    }


    /// <summary>
    /// Constructs a new instance of the PredictmainShamodel class.
    /// </summary>
    public PredictmainShamodel()
    {
    }


    #endregion Constructors

    #region Finalize

    /// <summary internal= "true">
    /// Class destructor called by the CLR garbage collector.
    /// </summary>
    ~PredictmainShamodel()
    {
      Dispose(false);
    }


    /// <summary>
    /// Frees the native resources associated with this object
    /// </summary>
    public void Dispose()
    {
      Dispose(true);

      GC.SuppressFinalize(this);
    }


    /// <summary internal= "true">
    /// Internal dispose function
    /// </summary>
    protected virtual void Dispose(bool disposing)
    {
      if (!disposed)
      {
        disposed= true;

        if (disposing)
        {
          // Free managed resources;
        }

        // Free native resources
      }
    }


    #endregion Finalize

    #region Methods

    /// <summary>
    /// Provides a void output, 0-input MWArrayinterface to the libsvmread M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    ///
    public void libsvmread()
    {
      mcr.EvaluateFunction(0, "libsvmread", new MWArray[]{});
    }


    /// <summary>
    /// Provides a void output, 1-input MWArrayinterface to the libsvmread M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="varargin">Array of MWArrays representing the input arguments 1
    /// through varargin.length</param>
    ///
    public void libsvmread(params MWArray[] varargin)
    {
      mcr.EvaluateFunction(0, "libsvmread", varargin);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the libsvmread M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] libsvmread(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "libsvmread", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the libsvmread M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="varargin">Array of MWArrays representing the input arguments 1
    /// through varargin.length</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] libsvmread(int numArgsOut, params MWArray[] varargin)
    {
      return mcr.EvaluateFunction(numArgsOut, "libsvmread", varargin);
    }


    /// <summary>
    /// Provides an interface for the libsvmread function in which the input and output
    /// arguments are specified as an array of MWArrays.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of MWArray output arguments</param>
    /// <param name= "argsIn">Array of MWArray input arguments</param>
    ///
    public void libsvmread(int numArgsOut, ref MWArray[] argsOut, MWArray[] argsIn)
    {
      mcr.EvaluateFunction("libsvmread", numArgsOut, ref argsOut, argsIn);
    }


    /// <summary>
    /// Provides a void output, 0-input MWArrayinterface to the libsvmwrite M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    ///
    public void libsvmwrite()
    {
      mcr.EvaluateFunction(0, "libsvmwrite", new MWArray[]{});
    }


    /// <summary>
    /// Provides a void output, 1-input MWArrayinterface to the libsvmwrite M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="varargin">Array of MWArrays representing the input arguments 1
    /// through varargin.length</param>
    ///
    public void libsvmwrite(params MWArray[] varargin)
    {
      mcr.EvaluateFunction(0, "libsvmwrite", varargin);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the libsvmwrite M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] libsvmwrite(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "libsvmwrite", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the libsvmwrite M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="varargin">Array of MWArrays representing the input arguments 1
    /// through varargin.length</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] libsvmwrite(int numArgsOut, params MWArray[] varargin)
    {
      return mcr.EvaluateFunction(numArgsOut, "libsvmwrite", varargin);
    }


    /// <summary>
    /// Provides an interface for the libsvmwrite function in which the input and output
    /// arguments are specified as an array of MWArrays.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of MWArray output arguments</param>
    /// <param name= "argsIn">Array of MWArray input arguments</param>
    ///
    public void libsvmwrite(int numArgsOut, ref MWArray[] argsOut, MWArray[] argsIn)
    {
      mcr.EvaluateFunction("libsvmwrite", numArgsOut, ref argsOut, argsIn);
    }


    /// <summary>
    /// Provides a single output, 0-input MWArrayinterface to the PredictmainSha
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// SVM²âÊÔº¯Êý
    /// </remarks>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray PredictmainSha()
    {
      return mcr.EvaluateFunction("PredictmainSha", new MWArray[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input MWArrayinterface to the PredictmainSha
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// SVM²âÊÔº¯Êý
    /// </remarks>
    /// <param name="proteinsequence">Input argument #1</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray PredictmainSha(MWArray proteinsequence)
    {
      return mcr.EvaluateFunction("PredictmainSha", proteinsequence);
    }


    /// <summary>
    /// Provides a single output, 2-input MWArrayinterface to the PredictmainSha
    /// M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// SVM²âÊÔº¯Êý
    /// </remarks>
    /// <param name="proteinsequence">Input argument #1</param>
    /// <param name="Specificity">Input argument #2</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray PredictmainSha(MWArray proteinsequence, MWArray Specificity)
    {
      return mcr.EvaluateFunction("PredictmainSha", proteinsequence, Specificity);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the PredictmainSha M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// SVM²âÊÔº¯Êý
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] PredictmainSha(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "PredictmainSha", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the PredictmainSha M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// SVM²âÊÔº¯Êý
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="proteinsequence">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] PredictmainSha(int numArgsOut, MWArray proteinsequence)
    {
      return mcr.EvaluateFunction(numArgsOut, "PredictmainSha", proteinsequence);
    }


    /// <summary>
    /// Provides the standard 2-input MWArray interface to the PredictmainSha M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// SVM²âÊÔº¯Êý
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="proteinsequence">Input argument #1</param>
    /// <param name="Specificity">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] PredictmainSha(int numArgsOut, MWArray proteinsequence, MWArray 
                              Specificity)
    {
      return mcr.EvaluateFunction(numArgsOut, "PredictmainSha", proteinsequence, Specificity);
    }


    /// <summary>
    /// Provides an interface for the PredictmainSha function in which the input and
    /// output
    /// arguments are specified as an array of MWArrays.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// M-Documentation:
    /// SVM²âÊÔº¯Êý
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of MWArray output arguments</param>
    /// <param name= "argsIn">Array of MWArray input arguments</param>
    ///
    public void PredictmainSha(int numArgsOut, ref MWArray[] argsOut, MWArray[] argsIn)
    {
      mcr.EvaluateFunction("PredictmainSha", numArgsOut, ref argsOut, argsIn);
    }


    /// <summary>
    /// Provides a void output, 0-input MWArrayinterface to the svmpredict M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    ///
    public void svmpredict()
    {
      mcr.EvaluateFunction(0, "svmpredict", new MWArray[]{});
    }


    /// <summary>
    /// Provides a void output, 1-input MWArrayinterface to the svmpredict M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="varargin">Array of MWArrays representing the input arguments 1
    /// through varargin.length</param>
    ///
    public void svmpredict(params MWArray[] varargin)
    {
      mcr.EvaluateFunction(0, "svmpredict", varargin);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the svmpredict M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] svmpredict(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "svmpredict", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the svmpredict M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="varargin">Array of MWArrays representing the input arguments 1
    /// through varargin.length</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] svmpredict(int numArgsOut, params MWArray[] varargin)
    {
      return mcr.EvaluateFunction(numArgsOut, "svmpredict", varargin);
    }


    /// <summary>
    /// Provides an interface for the svmpredict function in which the input and output
    /// arguments are specified as an array of MWArrays.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of MWArray output arguments</param>
    /// <param name= "argsIn">Array of MWArray input arguments</param>
    ///
    public void svmpredict(int numArgsOut, ref MWArray[] argsOut, MWArray[] argsIn)
    {
      mcr.EvaluateFunction("svmpredict", numArgsOut, ref argsOut, argsIn);
    }


    /// <summary>
    /// Provides a void output, 0-input MWArrayinterface to the svmtrain M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    ///
    public void svmtrain()
    {
      mcr.EvaluateFunction(0, "svmtrain", new MWArray[]{});
    }


    /// <summary>
    /// Provides a void output, 1-input MWArrayinterface to the svmtrain M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="varargin">Array of MWArrays representing the input arguments 1
    /// through varargin.length</param>
    ///
    public void svmtrain(params MWArray[] varargin)
    {
      mcr.EvaluateFunction(0, "svmtrain", varargin);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the svmtrain M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] svmtrain(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "svmtrain", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the svmtrain M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="varargin">Array of MWArrays representing the input arguments 1
    /// through varargin.length</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] svmtrain(int numArgsOut, params MWArray[] varargin)
    {
      return mcr.EvaluateFunction(numArgsOut, "svmtrain", varargin);
    }


    /// <summary>
    /// Provides an interface for the svmtrain function in which the input and output
    /// arguments are specified as an array of MWArrays.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of MWArray output arguments</param>
    /// <param name= "argsIn">Array of MWArray input arguments</param>
    ///
    public void svmtrain(int numArgsOut, ref MWArray[] argsOut, MWArray[] argsIn)
    {
      mcr.EvaluateFunction("svmtrain", numArgsOut, ref argsOut, argsIn);
    }


    /// <summary>
    /// This method will cause a MATLAB figure window to behave as a modal dialog box.
    /// The method will not return until all the figure windows associated with this
    /// component have been closed.
    /// </summary>
    /// <remarks>
    /// An application should only call this method when required to keep the
    /// MATLAB figure window from disappearing.  Other techniques, such as calling
    /// Console.ReadLine() from the application should be considered where
    /// possible.</remarks>
    ///
    public void WaitForFiguresToDie()
    {
      mcr.WaitForFiguresToDie();
    }



    #endregion Methods

    #region Class Members

    private static MWMCR mcr= null;

    private bool disposed= false;

    #endregion Class Members
  }
}
