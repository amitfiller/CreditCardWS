using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public class Debit
{
    private string cardNum;
    private string cardType;
    private string cardOwnerId;
    private int expMonth;
    private int expYear;
    
    public Debit()
    {
        this.cardNum = "";
        this.cardType = "";
        this.cardOwnerId = "";
        this.expMonth = 0;
        this.expYear = 0;
    }

    public Debit(string cardNum, string cardType, string cardOwnerId,int expMonth, int expYear)
    {
        this.cardNum = cardNum;
        this.cardType = cardType;
        this.cardOwnerId = cardOwnerId;
        this.expMonth = expMonth;
        this.expYear = expYear;
    }

    public string CardNum
    {
        get { return this.cardNum; }
        set { this.cardNum = value; }
    }

    public string CardType
    {
        get { return this.cardType; }
        set { this.cardType = value; }
    }

    public string CardOwnerId
    {
        get { return this.cardOwnerId; }
        set { this.cardOwnerId = value; }
    }
    
    public int ExpMonth
    {
        get { return this.expMonth; }
        set { this.expMonth = value; }
    }

    public int ExpYear
    {
        get { return this.expYear; }
        set { this.expYear = value; }
    }
    
}
