using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using System.Threading.Tasks;
using UnityDemo.Models.Scorers;
using UnityDemo.Models;
namespace Assets.Tests
{
    class BasisScorerTest_강소영
    {
        [Test]
        public void 광땡으로_이기는_경우()
        {
            Scorer scorer = new BasicScorer();
            Player p1 = new Player("우명진");
            p1.AddCard(new Card(3, false));
            p1.AddCard(new Card(7, false));


            Player p2 = new Player("지현정");
            p2.AddCard(new Card(1, true));
            p2.AddCard(new Card(8, true));

            Player winner = scorer.GetWinner(p1, p2);

            Assert.AreEqual(p2, winner);
        }
        [Test]
        public void 땡으로_이긴_경우()
        {
            Scorer scorer = new BasicScorer();
            Player p1 = new Player("우명진");
            p1.AddCard(new Card(8, false));
            p1.AddCard(new Card(8, false));

            Player p2 = new Player("지현정");
            p2.AddCard(new Card(1, false));
            p2.AddCard(new Card(8, false));

            Player winner = scorer.GetWinner(p1, p2);

            Assert.AreEqual(p1, winner);
        }
        [Test]
        public void 끗으로_이긴_경우()
        {
            Scorer scorer = new BasicScorer();
            Player p1 = new Player("우명진");
            p1.AddCard(new Card(3, false));
            p1.AddCard(new Card(2, false));

            Player p2 = new Player("지현정");
            p2.AddCard(new Card(1, false));
            p2.AddCard(new Card(8, false));

            Player winner = scorer.GetWinner(p1, p2);

            Assert.AreEqual(p2, winner);
        }


    }

}
