using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public interface IResult

        //Temel voidler icin baslangic  
    {
        bool Success { get; } //get = "sadece okunabílir demekti. Degisitirme islemleri set ile olur..."
        string Message { get; }
    }
}
