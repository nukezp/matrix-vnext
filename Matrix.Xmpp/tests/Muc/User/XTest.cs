﻿using Matrix.Xmpp.Muc.User;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using X = Matrix.Xmpp.Muc.User.X;

namespace Matrix.Xmpp.Tests.Muc.User
{
    [TestClass]
    public class XTest
    {
        string xml1 = @"<x xmlns='http://jabber.org/protocol/muc#user'>
                <invite to='hecate@shakespeare.lit' />
                <password>cauldronburn</password>               
              </x>";
        
        
        [TestMethod]
        public void Test1()
        {
            var x = new X();
            x.AddInvite(new Invite { To = "hecate@shakespeare.lit"});
            x.Password = "cauldronburn";
            
            x.ShouldBe(xml1);
        }
    }
}