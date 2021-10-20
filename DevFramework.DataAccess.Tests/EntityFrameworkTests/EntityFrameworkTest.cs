using DevFramework.Northwind.DataAccess.Concrete.EntityFramework;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DevFramework.DataAccess.Tests.EntityFrameworkTests
{
    [TestClass]
    public class NHibernateTest
    {
        [TestMethod]
        public void Get_all_returns_all_products()
        {
            EfProductDal productDal = new EfProductDal();

            var result = productDal.GetList();

            Assert.AreEqual(80, result.Count);
        }
    }
}
