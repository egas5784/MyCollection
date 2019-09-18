using System;

namespace Collection
{
    class UserType
    {
        object id;
        string krut;
        public string Value()
        {
            return krut;
        }
        public object Id()
        {
            return id;
        }
         public UserType()
        {
            id = 0;
            krut = "";
        }
        public UserType(object b, string s)
        {
            id = b;
            krut = s;
        }
        public override bool Equals(object obj)
        {
            if (obj is UserType)
            {
                UserType el = (UserType)obj;
                return id == el.id && krut == el.krut;
            }
            else
            {
                return false;
            }
        }
        public override int GetHashCode()
        {
            return id.GetHashCode()*17+krut.GetHashCode();
        }
        public override string ToString()
        {
            return base.ToString();
        }
        public static Boolean operator ==(UserType t1,UserType t2)
        {
            return t1.krut == t2.krut;
        }
        public static Boolean operator !=(UserType t1, UserType t2)
        {
            return t1.krut != t2.krut;
        }
        public static UserType operator +(UserType t1, UserType t2)
        {
            UserType tn =new UserType(t1.id, t1.krut + t2.krut);
            return tn;
        }
    }
}
