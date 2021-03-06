// <copyright file="DelocoTest.cs">Copyright ©  2017</copyright>
using System;
using Deloco_Pos_C.base_classes;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Deloco_Pos_C.base_classes.Tests
{
    /// <summary>This class contains parameterized unit tests for Deloco</summary>
    [PexClass(typeof(Deloco))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class DelocoTest
    {
        /// <summary>Test stub for CreateUpdateBrand(Int32, String, Int32, Int32)</summary>
        [PexMethod]
        internal int CreateUpdateBrandTest(
            [PexAssumeUnderTest]Deloco target,
            int brandid,
            string BrandName,
            int BrandWeight,
            int BrandSortOrder
        )
        {
            int result
               = target.CreateUpdateBrand(brandid, BrandName, BrandWeight, BrandSortOrder);
            return result;
            // TODO: add assertions to method DelocoTest.CreateUpdateBrandTest(Deloco, Int32, String, Int32, Int32)
        }
    }
}
