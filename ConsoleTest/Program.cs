using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete;
using System;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            MusteriTabloManager musteriler = new MusteriTabloManager(new EFMusteriTabloDal());
            foreach (var musteri in musteriler.GetAll().Data)
            {
                Console.WriteLine($"{musteri.MusteriID} - {musteri.MusteriIsim}");
            }
        }
    }
}
