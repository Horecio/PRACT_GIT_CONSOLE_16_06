using GIT_CONSOLE.Classes;

namespace TESTS
{
    public class Tests
    {
        [SetUp]
        public void Setup ()
        {


        }
        [Test]


        public void Test1 ()
        {
            string input = "������ ����";
            string actual = Vagner.Encrypt(input);
            string expected = "��58�������";
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void Test2 ()
        {
            string input = "������ ����";
            string actual = Vagner.Encrypt(input);
            string expected = "��58�������";
            Assert.AreEqual(expected, actual);

        }




        [Test]
        public void Test3 ()
        {
            string input = "������ ����";
            string actual = Vagner.Decrypt(input);
            string expected = "����1������";
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void Test4 ()
        {
            string input = "������ ����";
            string actual = Vagner.Decrypt(input);
            string expected = "����1������";
            Assert.AreEqual(expected, actual);

        }










        //[Test]
        ////public void Test5 ()
        ////{
        ////    int key = 1;
        ////    string input = "������ ����";

        ////    string actual = Cesar.Crypt(input);

         


        ////    string expected = "����1������";
        ////    Assert.AreEqual(expected, actual);

        ////}








    }
}