using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.NorthWindDB.ORM.MsSqlServer
{
    class EntityReflection
    {
        Dictionary<string, string> dataType;
        PropertyInfo propertyInfo;
        
        public EntityReflection(PropertyInfo propertyInfo,Dictionary<string,string> dataType)
        {
            this.propertyInfo = propertyInfo;
            this.dataType = dataType;
        }
        
        public string PropertyName
        {
            get
            {
                return propertyInfo.Name;
            }
        }

        public string PropertyType 
        {
            get
            {
                string sqlDataType= dataType[propertyInfo.PropertyType.Name];
                if (propertyInfo.CustomAttributes.Any(p => p.AttributeType.Name == "MaxLengthAttribute"))
                {
                    sqlDataType = sqlDataType.Replace(dataType["maxLength"], propertyInfo.CustomAttributes.SingleOrDefault(p => p.AttributeType.Name == "MaxLengthAttribute").ConstructorArguments[0].Value.ToString());
                }   
                return sqlDataType;
            }
        }
        public string Required 
        {
            get
            {   
                if (propertyInfo.CustomAttributes.Any(p=>p.AttributeType.Name== "RequiredAttribute"))
                {
                    return "NOT NULL";
                }
                return "NULL";
            } 
        }
        
        public bool Key
        {
            get
            {
                if (propertyInfo.CustomAttributes.Any(p=>p.AttributeType.Name=="KeyAttribute"))
                {
                    return true;
                }
                return false;
            }
        }
        
        public bool Identity
        {
            get
            {
                if (propertyInfo.CustomAttributes.Any(p => p.AttributeType.Name == "DatabaseGeneratedAttribute"))
                {
                    return Convert.ToInt32(propertyInfo.CustomAttributes.SingleOrDefault(p => p.AttributeType.Name == "DatabaseGeneratedAttribute").ConstructorArguments[0].Value) == 1;
                }
                return false;
            }
        }
    }
}
