namespace PersonalFinanceProgram
public class Transaction{ //Klass som har alla fält inom transaktioner.
    public decimal Amount {get;set;} //Beloppet på kontot.
    public string Type {get;set;} //För att se om det är en inkomst eller utgift.
    public DateTime Date {get;set;} //Datum för transaktion.
}
public class TransactionManager{ //Klass som hanterar transaktionerna.
    private list <Transaction> transactionList = new list<Transaction>(); //
    public void AddTransactions(){
        transactionList.Add
    }
    public void RemoveTransactions(){

    }
}