using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


class BankAccount
{
    private int _balance;
    private bool _available = false;

    public int Balance
    {
        get
        {
            if (_available)
            {
                return _balance;
            }
            else
            {
                throw new InvalidOperationException();
            }
        }
        protected set
        {
            _balance = value;
        }
    }

    public void Open()
    {
        _available = true;
    }

    public void UpdateBalance(int sum)
    {
        lock (this)
        {
            Balance += sum;
        }
    }

    public void Close()
    {
        _available = false;
    }
}

