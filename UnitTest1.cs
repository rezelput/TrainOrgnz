using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework.Internal.Execution;
using System;
using System.Collections.Generic;
using TrainOrgnz;
using Microsoft.EntityFrameworkCore;

namespace TestProject_train_
{
    public class InMemoryContext : OrgnzForm
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseInMemoryDatabase("Filename=:memory:");
        }
    }

    [TestClass]
    public class EventRepositoryTests
    {
        [TestMethod]
        public void PasteEventAndGetEvent_CorrectEvent()
        {
            using (var context = new InMemoryContext())
            {
                var tr = new train(context);
                var testEvent = new Event { Date = DateTime.Now, Name = Guid.NewGuid().ToString() };

                tr.AddEventAsync(testEvent).Wait();
                var eventFromDB = train.GetEventAsync(testEvent.Id).Result;

                Assert.IsTrue(testEvent.Name == eventFromDB.Name && testEvent.Date == eventFromDB.Date);
            }
        }
    }
}

