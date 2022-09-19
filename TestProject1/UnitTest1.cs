using Projekt_Magazyn;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {


        [TestMethod]
        public void HashMetod()
        {

            string licz = "95c5751369929e45e4713a6ab057dd736a7462ddcb6787ccf4c6a3b939216511";
            Console.WriteLine(licz.Length);
            string kupa = "robocze";
            string kupa2 = "admin";
            HashPassword hash =new HashPassword();
            var ty = hash.CreateSalt(10);
            //trzeba zapisaæ sól
            Console.WriteLine(ty);
            var a = hash.GenerateSHA256Hash(kupa, "oaP6OxuP3rifcQ ==");
            Console.WriteLine(a);

            var c = hash.GenerateSHA256Hash(kupa2, "oaP6OxuP3rifcQ ==");


            Assert.AreEqual(c, a);
            

        }
    }
}