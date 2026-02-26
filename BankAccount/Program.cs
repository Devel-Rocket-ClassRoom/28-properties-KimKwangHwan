using System;

BankAccount account = new BankAccount("123-456", "홍길동");
Console.WriteLine($"--- 50000원 입금 ---");
account.Deposit(50000);
Console.WriteLine($"잔액: {account.Balance}원");
Console.WriteLine($"--- 20000 출금 ---");
Console.WriteLine($"출금 성공: {account.Withdraw(20000)}"); 
Console.WriteLine($"잔액: {account.Balance}원");
Console.WriteLine($"--- 100000원 출금 시도 ---");
Console.WriteLine($"출금 성공: {account.Withdraw(100000)}");
Console.WriteLine($"잔액: {account.Balance}원");

class BankAccount
{
    private int _balance;
    public string AccountNumber
    {
        get;
    }

    public string OwnerName
    {
        get; set;
    }

    public int Balance
    {
        get { return _balance; }
        private set
        {
            if (value < 0)
            {
                _balance = 0;
            }
            else
            {
                _balance = value;
            }
        }
    }

    public BankAccount(string account_number, string owner)
    {
        AccountNumber = account_number;
        OwnerName = owner;
        Balance = 0;
        Console.WriteLine($"계좌번호: {AccountNumber}");
        Console.WriteLine($"예금주: {OwnerName}");
        Console.WriteLine($"잔액: {Balance}원");
    }

    public void Deposit(int amount)
    {
        if (amount > 0)
        {
            Balance += amount;
        }
    }

    public bool Withdraw(int amount)
    {
        if (Balance < amount)
        {
            return false;
        }
        Balance -= amount;
        return true;
    }
}