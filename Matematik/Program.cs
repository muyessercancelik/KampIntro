using System;

namespace Matematik
{
    class Program
    {
        static void Main(string[] args)
        {
            DortIslem dortIslem = new DortIslem();
            dortIslem.Topla(5, 6); // Benim toplama işlemini yapan Topla isminde bir metodum var. O da dortIslem class ın içinde 
                                    //olduğu için bu class tan bir örnek oluşturmamız gerekiyor.
            dortIslem.Topla(6, 9);

            dortIslem.Cikar(10, 7);
        }
    }
}
