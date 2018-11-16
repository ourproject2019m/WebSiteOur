using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class Child
{
    private int Cid;
    public int cid
    {
        get {return Cid; }
        set {Cid = value; }
    }
    private string CfName;
    public string cfname
    {
        get { return CfName; }
        set { CfName = value; }
    }
    private int Cage;
    public int cage
    {
        get { return Cage; }
        set { Cage = value; }
    }
    private string Csex;
    public string csex
    {
        get { return Csex; }
        set { Csex = value; }
    }
    private string Csensitivity;
    public string csensitivity
    {
        get { return Csensitivity; }
        set { Csensitivity = value; }
    }
    private string Cfood;
    public string cfood
    {
        get { return Cfood; }
        set { Cfood = value; }
    }
    private string CLimitations;
    public string climitations
    {
        get { return CLimitations; }
        set { CLimitations = value; }
    }
    private int Cidparent;
    public int cidparent
    {
        get { return Cidparent; }
        set { Cidparent = value; }
    }
    public Child(int Cid, string CfName, int Cage, string Csex, string Csensitivity, string Cfood, string CLimitations, int Cidparent)
    {
        this.Cid = Cid;
        this.CfName = CfName;
        this.Cage = Cage;
        this.Csex = Csex;
        this.Csensitivity = Csensitivity;
        this.Cfood = Cfood;
        this.CLimitations = CLimitations;
        this.Cidparent = Cidparent;
    }
}