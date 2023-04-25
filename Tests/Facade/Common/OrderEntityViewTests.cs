using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SemestriProject.Facade.Common;

namespace SemestriProject.Tests.Facade.Common
{
    [TestClass]
    public class OrderEntityViewTests : AbstractClassTests<OrderEntityView, UniqueEntityView>
    {
        private class testClass : OrderEntityView { }

        [TestInitialize]
        public override void TestInitialize()
        {
            base.TestInitialize();
            obj = new testClass();
        }

        [TestMethod]
        public void NameTest()
        {
            isNullableProperty(() => obj.Name, x => obj.Name = x);
        }

        [TestMethod]
        public void AddressRowTest()
        {
            isNullableProperty(() => obj.AddressRow, x => obj.AddressRow = x);
        }
        [TestMethod]
        public void PostCodeTest()
        {
            isNullableProperty(() => obj.PostCode, x => obj.PostCode = x);
        }
        [TestMethod]
        public void CityTest()
        {
            isNullableProperty(() => obj.City, x => obj.City = x);
        }
        [TestMethod]
        public void CountryTest()
        {
            isNullableProperty(() => obj.Country, x => obj.Country = x);
        }
        [TestMethod]
        public void ContactNameTest()
        {
            isNullableProperty(() => obj.ContactName, x => obj.ContactName = x);
        }
        [TestMethod]
        public void PhoneTest()
        {
            isNullableProperty(() => obj.Phone, x => obj.Phone = x);
        }
        [TestMethod]
        public void EMailTest()
        {
            isNullableProperty(() => obj.EMail, x => obj.EMail = x);
        }
        [TestMethod]
        public void QuantityTest()
        {
            isProperty(() => obj.Quantity, x => obj.Quantity = x);
        }
        [TestMethod]
        public void PackageTypeTest()
        {
            isNullableProperty(() => obj.PackageType, x => obj.PackageType = x);
        }
        [TestMethod]
        public void WeightTest()
        {
            isProperty(() => obj.Weight, x => obj.Weight = x);
        }
        [TestMethod]
        public void VolumeTest()
        {
            isProperty(() => obj.Volume, x => obj.Volume = x);
        }
        [TestMethod]
        public void LengthTest()
        {
            isProperty(() => obj.Length, x => obj.Length = x);
        }
        [TestMethod]
        public void WidthTest()
        {
            isProperty(() => obj.Width, x => obj.Width = x);
        }
        [TestMethod]
        public void HeightTest()
        {
            isProperty(() => obj.Height, x => obj.Height = x);
        }
        [TestMethod]
        public void ValueTest()
        {
            isProperty(() => obj.Value, x => obj.Value = x);
        }
        [TestMethod]
        public void GoodsDescriptionTest()
        {
            isNullableProperty(() => obj.GoodsDescription, x => obj.GoodsDescription = x);
        }
        [TestMethod]
        public void DangerousGoodsTest()
        {
            isProperty(() => obj.DangerousGoods, x => obj.DangerousGoods = x);
        }
        [TestMethod]
        public void TemperatureSensitiveTest()
        {
            isProperty(() => obj.TemperatureSensitive, x => obj.TemperatureSensitive = x);
        }
        [TestMethod]
        public void CustomerCommentsTest()
        {
            isNullableProperty(() => obj.CustomerComments, x => obj.CustomerComments = x);
        }

        [TestMethod]
        public void AcceptTermsTest()
        {
            isProperty(() => obj.AcceptTerms, x => obj.AcceptTerms = x);
        }

    }
}
