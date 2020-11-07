using System;
using System.Linq;
using Lesson_1_Ex_14;
using NUnit.Framework;

namespace Ex_14_Tests
{
    [TestFixture]
    public class Tests
    {
        [TestCase(1,1)]
        [TestCase(0,1)]
        [TestCase(-1,1)]
        [TestCase(20,2)]
        [TestCase(-20,2)]
        [TestCase(302,3)]
        public void IntLength(int input, int rightResult)
        {
            var result = input.Lenght();
            Assert.That(result, Is.EqualTo(rightResult));
        }
        [TestCase(1,1,true)]
        [TestCase(1,-1,true)]
        [TestCase(0,0,true)]
        [TestCase(1,2,false)]
        [TestCase(101,1,true)]
        [TestCase(110,10,true)]
        [TestCase(111,10,false)]
        [TestCase(256,16,false)]
        
        public void LastNumbersEquals(int input,int to, bool rightResult)
        {

            var result = Program.LastNumbersEquals(input,to);
            Assert.That(result, Is.EqualTo(rightResult));
        }
        [TestCase(0,true)]
        [TestCase(1,true)]
        [TestCase(5,true)]
        [TestCase(6,true)]
        [TestCase(25,true)]
        [TestCase(76,true)]
        [TestCase(376,true)]
        [TestCase(625,true)]
        [TestCase(9376,true)]
        [TestCase(90_625,true)]
        
        [TestCase(87231,false)]
        [TestCase(16,false)]
        
        public void IsAmorf(int input, bool rightResult)
        {

            var result = Program.IsAutomorf(input);
            Assert.That(result, Is.EqualTo(rightResult));
        }
        [TestCase(1,1)]
        [TestCase(-1,1)]
        [TestCase(0,0)]
        [TestCase(int.MaxValue,int.MaxValue)]
        public void Abs(int input, int rightResult)
        {
            
            var result = input.Abs();
            Assert.That(result, Is.EqualTo(rightResult));
        }
        [Test]
        public void AbsMin()
        {
            
            Assert.Throws<OverflowException>(() =>
            {
                var result = int.MinValue.Abs();
            });
            
        }
        [TestCase(100,new []{0,1,5,6,25,76})]
        public void GetAutomorfs(int input, int [] rightResult )
        {
            var result = Program.GetAutomorfs(input);
            var ok = result.SequenceEqual(rightResult);
            Assert.That(ok,Is.EqualTo(true));

        }

        [TestCase(0,(uint)0 ,0)]
        [TestCase(0,(uint)1 ,0)]
        [TestCase(1,(uint)0 ,1)]
        [TestCase(5,(uint)2 ,25)]
        [TestCase(3,(uint)3 ,27)]
        [TestCase(-5,(uint)2 ,25)]
        [TestCase(-3,(uint)3 ,-27)]
        public void Power(int input,uint power, int rightResult)
        {
            var result = input.PowerOf( power);
            Assert.That(result,Is.EqualTo(rightResult));
        }
    }
}