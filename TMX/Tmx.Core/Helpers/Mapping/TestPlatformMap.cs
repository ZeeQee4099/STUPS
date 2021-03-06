﻿/*
 * Created by SharpDevelop.
 * User: Alexander Petrovskiy
 * Date: 5/31/2013
 * Time: 3:46 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

namespace Tmx
{
    //    using System.Data.SQLite;
    using FluentNHibernate.Mapping;

    /// <summary>
    /// Description of TestPlatformMap.
    /// </summary>
    public class TestPlatformMap : ClassMap<TestPlatform>
    {
        public TestPlatformMap()
        {
            // Id(x => x.DbId);
            Id(x => x.UniqueId);
            Map(x => x.Id);
            Map(x => x.Name);
            Map(x => x.Description);
            
            Map(x => x.OperatingSystem);
            Map(x => x.Version);
            Map(x => x.Architecture);
            Map(x => x.Language);
        }
    }
}
