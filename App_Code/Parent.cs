using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class Parent
{
    private int Pid;
    public int pid
    {
        get { return Pid; }
        set { Pid = value; }
    }
    private string PfName;
    public string pfname
    {
        get { return PfName; }
        set { PfName = value; }
    }
    private string Pemail;
    public string pmail
    {
        get { return Pemail; }
        set { Pemail = value; }
    }
   
    private string Ppass;
    public string ppass
    {
        get { return Ppass; }
        set { Ppass = value; }
    }
    private int PidChild;
    public int pidchild
    {
        get { return PidChild; }
        set { PidChild = value; }
    }
    public Parent (int Pid,string PfName, string Pemail, string Ppass,int PidChild)
    {
        this.Pid = Pid;
        this.PfName = PfName;
        this.Pemail = Pemail;
        this.Ppass = Ppass;
        this.PidChild = PidChild;
    }
}