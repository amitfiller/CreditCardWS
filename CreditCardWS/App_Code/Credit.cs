using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using System.Data.OleDb;

/// <summary>
/// Summary description for Credit
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]

public class Credit : System.Web.Services.WebService
{
    const string FILE_NAME = "CreditWS.accdb";
    public string connectionStr;
    public Credit()
    {
        string location = HttpContext.Current.Server.MapPath("~/App_Data/" + FILE_NAME);
        connectionStr = @"Provider=Microsoft.ACE.OLEDB.12.0; data source=" + location;
    }

    [WebMethod]
    public string DebitCreditCard(Debit debit)
    {
        string queryStr = @"SELECT status FROM Debits
                            where cardNum = '" + debit.CardNum + "' AND cardType = '" + debit.CardType +
                            "' AND  cardOwnerID = '" + debit.CardOwnerId + "' AND expYear = " + debit.ExpYear +
                            " AND  expMonth = " + debit.ExpMonth;
        OleDbConnection connectObj = new OleDbConnection(connectionStr);
        OleDbCommand cmd = new OleDbCommand(queryStr, connectObj);
        object obj = null;

        try
        {
            connectObj.Open();
            obj = cmd.ExecuteScalar();
        }

        catch (Exception ex)
        {
            throw ex;
        }

        finally
        {
            connectObj.Close();
        }

        if (obj == null)
        {
            return "incorrect card properties.";
        }

        return (string)obj;

    }
}
