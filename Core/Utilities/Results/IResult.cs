using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    //Temel voidler için başlangıç
    public interface IResult
    {
        //yapmaya çalıştığın ekleme işlemi başarılı ise true, değilse false döndürür.
        bool Success { get; } //get=sadece okunabilir demektir.

        string Message { get; }
    }
}
