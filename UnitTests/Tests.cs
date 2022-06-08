using Otus.HomeWork.UnitTests;

namespace UnitTests
{
    public class Tests
    {
        HWMath hwMath = new HWMath();
        double[]? roots = new double[] { };
                
        private void checkSolveException()
        {
            hwMath.SolveQuadraticEquation(0.0, 0.0, 1.0);
        }

        [Fact]
        public void CheckArgWithZero()
        {
            Action action = new Action(checkSolveException);
            Assert.Throws<Exception>(action) ;
        }        
        

        [Fact]
        public void CheckZeroRoots()
        {
            roots = hwMath.SolveQuadraticEquation(1.0, 0.0, 1.0);
            Assert.Empty(roots);
        }

        [Fact]
        public void CheckOneRoot()
        {
            roots = hwMath.SolveQuadraticEquation(1.0, 2.0, 1.0);
            Assert.Single(roots);
            Assert.True(roots[0].Equals(-1.0));
        }

        [Fact]
        public void CheckTwoRoots()
        {
            roots = hwMath.SolveQuadraticEquation(1.0, 0.0, -1.0);
            Assert.Equal(2, roots.Length);
            Assert.True(roots[0].Equals(1.0));
            Assert.True(roots[1].Equals(-1.0));
        }
    }
}