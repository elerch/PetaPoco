// PetaPoco - A Tiny ORMish thing for your POCO's.
// Copyright © 2011-2012 Topten Software.  All Rights Reserved.

using System;
using System.Data;
using PetaPoco.Internal;

namespace PetaPoco.DatabaseTypes
{
    class FirebirdDatabaseType : DatabaseType
    {
        public override string GetParameterPrefix(string ConnectionString)
        {
            return "@";
        }

        public override string EscapeSqlIdentifier(string str)
        {
            return string.Format("\"{0}\"", str);
        }

        public override string GetExistsSql()
        {
            return "SELECT EXISTS (SELECT 1 FROM {0} WHERE {1})";
        }
    }
}
