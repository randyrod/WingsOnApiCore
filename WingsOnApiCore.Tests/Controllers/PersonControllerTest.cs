using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WingsOnApiCore.Controllers;
using WingsOnApiCore.Models;
using Xunit;
using Moq;
using WingsOnApiCore.Services.Abstract;

namespace WingsOnApiCore.Tests.Controllers
{
    public class PersonControllerTest
    {
        [Fact]
        public void Test_Get_Person_From_Id()
        {
            var mockRepo = new Mock<IPersonService>();
            var testSession = GetTestSession();
            mockRepo.Setup(service => service.Get(1)).Returns(testSession);
            
            var controller = new PersonController(mockRepo.Object);

            var result = controller.Get(1);

            var typ = result as OkObjectResult;
                        
            Assert.NotNull(typ);

            var val = typ.Value as PersonModel;
            
            Assert.NotNull(val);

            Assert.Equal(val.Id, testSession.Id);
        }

        [Fact]
        public void Test_Get_All_People()
        {
            var mockRepo = new Mock<IPersonService>();
            var testSessions = GetTestSessions();
            var personModels = testSessions as PersonModel[] ?? testSessions.ToArray();
            mockRepo.Setup(service => service.GetAll()).Returns(personModels);
            
            var controller = new PersonController(mockRepo.Object);

            var result = controller.Get() as OkObjectResult;
            
            Assert.NotNull(result);

            var resultValue = result.Value as IEnumerable<PersonModel>;
            
            Assert.NotNull(resultValue);
            
            Assert.Equal(resultValue, personModels);

        }

        private IEnumerable<PersonModel> GetTestSessions()
        {
            var testList = new List<PersonModel>();

            for (int i = 0; i < 100; i++)
            {
                testList.Add(new PersonModel
                {
                    Address = "Address1",
                    DateBirth = DateTime.Now - TimeSpan.FromDays(i),
                    Email = $"email{i}@email.com",
                    Gender = i % 2 == 0 ? GenderType.Male : GenderType.Female,
                    Id = i,
                    Name = $"Person {i}"
                });
            }

            return testList;
        }

        private PersonModel GetTestSession()
        {   
            return new PersonModel
            {
                Id = 1,
                Address = "Address1",
                DateBirth = DateTime.Now.Subtract(TimeSpan.FromDays(1000)),
                Gender = GenderType.Female,
                Name = "Person Test",
                Email = "person@test.com"
            }; 
        }
    }
}