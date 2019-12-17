using Group15.EventManager.Data.Context;
using Group15.EventManager.Domain.Models;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using System.Linq;

namespace Tests
{
    public class Tests
    {
        protected SqlContext Db;

        [SetUp]
        public void Setup()
        {
            Db = new SqlContext();
        }

        [Test]
        public void Test1()
        {
            var e = Db.Set<Event>().FirstOrDefault(ev => ev.Name == "Vinsmagning i hyggelige omgivelser");
            Assert.AreEqual(e.Name, "Vinsmagning i hyggelige omgivelser");
        }
    }
}