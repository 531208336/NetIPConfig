using System;
using System.Diagnostics;
using System.Text.RegularExpressions;
public class Shell
{

    public String Command {get;set;}
    public String Arguments { get; set; }
    public String Pattern { get; set; }
    public String Result { get; set; }
    private Match match { get; set; }

    public String FullCommand {
        get {
            return string.Format("{0} {1}", Command, Arguments);
        }
    }

   
    public GroupCollection Values
    {
        get
        {
            return match.Groups;
        }
    }

    public bool Execute()
    {
        Process pNet = new Process();
        ProcessStartInfo psi = new ProcessStartInfo(Command);
        psi.Arguments = Arguments;
        psi.RedirectStandardOutput = true;
        psi.UseShellExecute = false;
        psi.CreateNoWindow = true;
        pNet.StartInfo = psi;
        pNet.Start();
        Result = pNet.StandardOutput.ReadToEnd();

        Regex Ex = new Regex(Pattern);

        match = Ex.Match(Result);

        return match.Success ;
    }


}
