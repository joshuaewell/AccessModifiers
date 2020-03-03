using AccessModifierProject;
using NUnit.Framework;
using SecondAccessModifierProject;
using ThirdAccessModifierProject;

namespace AccessModifierUnitTestProject
{
    public class Tests
    {
        private AssemblyAClass1 _aClass1;
        private AssemblyAClass2 _aClass2;
        private AssemblyBClass3 _bClass3;
        private AssemblyCClass4 _cClass4;
        [SetUp]
        public void Setup()
        {
            _aClass1 = new AssemblyAClass1();
            _aClass2 = new AssemblyAClass2();
            _bClass3 = new AssemblyBClass3();
            _cClass4 = new AssemblyCClass4();
        }

        [Test]
        public void AssemblyAClass1_ShouldOnlyReturn_PublicResults()
        {
            // Arrange
            // AssemblyAClass1 is itself

            // Act
            var aPrivate = _aClass1.A_PublicFunctionToAccessAPrivateFunction();
            var aPublic = _bClass3.PublicFunctionOfAssemblyAClass1();

            // Assert
            Assert.That(aPrivate, Is.EqualTo("A_PrivateFunctionValue"));
            Assert.That(aPublic, Is.EqualTo("A_PublicFunctionValue"));
        }

        [Test]
        public void AssemblyBClass3ShouldOnlyReturnPublicResultOfAssemblyAClass1()
        {
            // Arrange
                // AssemblyBClass3 has an instance of AssemblyAClass1 and is an external Assembly
                // The only visible item is the public method.

            // Act
            var b3Private = _bClass3.PrivateFunctionOfAssemblyAClass1();
            var b3Public = _bClass3.PublicFunctionOfAssemblyAClass1();
            var b3Internal = _bClass3.InternalFunctionOfAssemblyAClass1();
            var b3Protected = _bClass3.ProtectedFunctionOfAssemblyAClass1();
            var b3ProtectedInternal = _bClass3.ProtectedInternalFunctionOfAssemblyAClass1();
            var b3PrivateProtected = _bClass3.PrivateProtectedFunctionOfAssemblyAClass1();

            // Assert
            Assert.That(b3Private, Is.Not.EqualTo("A_PrivateFunctionValue"));
            Assert.That(b3Public, Is.EqualTo("A_PublicFunctionValue"));
            Assert.That(b3Protected, Is.Not.EqualTo("A_ProtectedFunctionValue"));
            Assert.That(b3Internal, Is.Not.EqualTo("A_InternalFunctionValue"));
            Assert.That(b3ProtectedInternal, Is.Not.EqualTo("A_ProtectedInternalFunctionValue"));
            Assert.That(b3PrivateProtected, Is.Not.EqualTo("A_PrivateProtectedFunctionValue"));
        }

        [Test]
        public void AssemblyAClass2ShouldReturnAllResultsOfAssemblyAClass1_ExceptPrivate()
        {
            // Arrange
                // AssemblyAClass2 Inherits AssemblyAClass1 and is in the same Assembly,
                // which allows all access except to Private Members/Methods

            // Act
            var a2Private = _aClass2.PrivateFunctionOfAssemblyAClass1();
            var a2Public = _aClass2.PublicFunctionOfAssemblyAClass1();
            var a2Internal = _aClass2.InternalFunctionOfAssemblyAClass1();
            var a2Protected = _aClass2.ProtectedFunctionOfAssemblyAClass1();
            var a2ProtectedInternal = _aClass2.ProtectedInternalFunctionOfAssemblyAClass1();
            var a2PrivateProtected = _aClass2.PrivateProtectedFunctionOfAssemblyAClass1();

            // Assert
            Assert.That(a2Private, Is.Not.EqualTo("A_PrivateFunctionValue"));
            Assert.That(a2Public, Is.EqualTo("A_PublicFunctionValue"));
            Assert.That(a2Protected, Is.EqualTo("A_ProtectedFunctionValue"));
            Assert.That(a2Internal, Is.EqualTo("A_InternalFunctionValue"));
            Assert.That(a2ProtectedInternal, Is.EqualTo("A_ProtectedInternalFunctionValue"));
            Assert.That(a2PrivateProtected, Is.EqualTo("A_PrivateProtectedFunctionValue"));
        }

        [Test]
        public void AssemblyDShouldReturnPublicAndProtectedResultsOfAssemblyA_ExceptPrivate_Internal_AndPrivateProtected()
        {
            // Arrange
                // AssemblyCClass4 Inherits AssemblyAClass1 and is in a separate Assembly,
                // which allows all access except to Private, Internal, and PrivateProtected Members/Methods

            // Act
            var c4Private = _cClass4.PrivateFunctionOfAssemblyAClass1();
            var c4Public = _cClass4.PublicFunctionOfAssemblyAClass1();
            var c4Internal = _cClass4.InternalFunctionOfAssemblyAClass1();
            var c4Protected = _cClass4.ProtectedFunctionOfAssemblyAClass1();
            var c4ProtectedInternal = _cClass4.ProtectedInternalFunctionOfAssemblyAClass1();
            var c4PrivateProtected = _cClass4.PrivateProtectedFunctionOfAssemblyAClass1();

            // Assert
            Assert.That(c4Private, Is.Not.EqualTo("A_PrivateFunctionValue"));
            Assert.That(c4Public, Is.EqualTo("A_PublicFunctionValue"));
            Assert.That(c4Protected, Is.EqualTo("A_ProtectedFunctionValue"));
            Assert.That(c4Internal, Is.Not.EqualTo("A_InternalFunctionValue"));
            Assert.That(c4ProtectedInternal, Is.EqualTo("A_ProtectedInternalFunctionValue"));
            Assert.That(c4PrivateProtected, Is.Not.EqualTo("A_PrivateProtectedFunctionValue"));
        }
    }
}