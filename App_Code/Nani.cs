using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Nani
/// </summary>
public class Nani
{
    private int Nid;
    public int nid
    {
        get { return Nid; }
        set { Nid = value; }
    }
    private string NfName;
    public string nfname
    {
        get { return NfName; }
        set { NfName = value; }
    }
    
    private string Naddress;
    public string naddress
    {
        get { return Naddress; }
        set { Naddress = value; }
    }
    private string Ncity;
    public string ncity
    {
        get { return Ncity; }
        set { Ncity = value; }
    }
    private string Nphon;
    public string nphon
    {
        get { return Nphon; }
        set { Nphon = value; }
    }
    private string Nmail;
    public string nmail
    {
        get { return Nmail; }
        set { Nmail = value; }
    }
    private string Npass;
    public string npass
    {
        get { return Npass; }
        set { Npass = value; }
    }
    private int NidChild;
    public int nidchild
    {
        get { return NidChild; }
        set { NidChild = value; }
    }
    public Nani(int Nid,string NfName,string Naddress,string Ncity,string Nphon,string Nmail,string Npass,int NidChild)
    {
        this.Nid = Nid;
        this.NfName = NfName;
        this.Naddress = Naddress;
        this.Ncity = Ncity;
        this.Nphon = Nphon;
        this.Nmail = Nmail;
        this.Npass = Npass;
        this.NidChild = NidChild;
    }
    
        
}
