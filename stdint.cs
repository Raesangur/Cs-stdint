﻿/* C# stdint */
/* By : Pascal-Emmanuel Lachance
 * https://www.github.com/Raesangur
 */

/*****************************************************************************/
/* TODO:
 * - Add, Substract, Divide, Multiply, Modulo, AND, OR, XOR, non-static
 *      - int16_t 
 *      - uint16_t
 *      - int32_t
 *      - uint32_t
 *      - int64_t
 *      - uint64_t
 * - test functionalities 
 * */

namespace stdint
{
    /****************************** int8_t ***********************************/
    class int8_t
    {
        public sbyte var = 0;

        #region Constructors
        public int8_t()                 { var = 0; }
        public int8_t(byte value)       { var = (sbyte)value; }
        public int8_t(sbyte value)      { var = value; }
        public int8_t(short value)      { var = (sbyte)value; }
        public int8_t(ushort value)     { var = (sbyte)value; }
        public int8_t(int value)        { var = (sbyte)value; }
        public int8_t(uint value)       { var = (sbyte)value; }
        public int8_t(long value)       { var = (sbyte)value; }
        public int8_t(ulong value)      { var = (sbyte)value; }
        public int8_t(float value)      { var = System.Convert.ToSByte(System.Math.Truncate(value)); }
        public int8_t(double value)     { var = System.Convert.ToSByte(System.Math.Truncate(value)); }
        public int8_t(int8_t value)     { var = value.var; }
        public int8_t(uint8_t value)    { var = (sbyte)value.var; }
        public int8_t(int16_t value)    { var = (sbyte)value.var; }
        public int8_t(uint16_t value)   { var = (sbyte)value.var; }
        public int8_t(int32_t value)    { var = (sbyte)value.var; }
        public int8_t(uint32_t value)   { var = (sbyte)value.var; }
        public int8_t(int64_t value)    { var = (sbyte)value.var; }
        public int8_t(uint64_t value)   { var = (sbyte)value.var; }
        #endregion

        #region types
        #region new types
        #region int8_t
        /* Unary operators */
        public static int8_t operator ++(int8_t obj)                    /* ++ */
        {
            obj.Increment();
            return obj;
        }
        public static int8_t operator --(int8_t obj)                    /* -- */
        {
            obj.Decrement();
            return obj;
        }
        public static int8_t operator -(int8_t obj)                     /* - (unary) */
        {
            return new int8_t(-obj.var);
        }
        public static int8_t operator +(int8_t obj)                     /* + (unary) */
        {
            return new int8_t(obj);
        }
        public static int8_t operator ~(int8_t obj)                     /* ~ */
        {
            return new int8_t(~obj.var);
        }

        /* Non-static math operations */
        public int8_t Add(int8_t val)                                   /* Addition */
        {
            this.var += val.var;
            return this;
        }
        public int8_t Substract(int8_t val)                             /* Substraction */
        {
            this.var -= val.var;
            return this;
        }
        public int8_t Multiply(int8_t val)                              /* Multiplication */
        {
            this.var *= val.var;
            return this;
        }
        public int8_t Divide(int8_t val)                                /* Division */
        {
            this.var /= val.var;
            return this;
        }
        public int8_t Modulo(int8_t val)                                /* Modulo */
        {
            this.var %= val.var;
            return this;
        }
        public int8_t AND(int8_t val)                                   /* Bitwise AND operation */
        {
            this.var &= val.var;
            return this;
        }
        public int8_t OR(int8_t val)                                    /* Bitwise OR operation */
        {
            this.var |= val.var;
            return this;
        }
        public int8_t XOR(int8_t val)                                   /* Bitwise XOR operation */
        {
            this.var ^= val.var;
            return this;
        }

        /* Math */
        public static int8_t operator +(int8_t var1, int8_t var2)       /* + */
        {
            return new int8_t(var1.var + var2.var);
        }
        public static int8_t operator -(int8_t var1, int8_t var2)       /* - */
        {
            return new int8_t(var1.var - var2.var);
        }
        public static int8_t operator *(int8_t var1, int8_t var2)       /* * */
        {
            return new int8_t(var1.var * var2.var);
        }
        public static int8_t operator /(int8_t var1, int8_t var2)       /* / */
        {
            return new int8_t(var1.var / var2.var);
        }
        public static int8_t operator %(int8_t var1, int8_t var2)       /* % */
        {
            return new int8_t(var1.var % var2.var);
        }
        public static int8_t operator &(int8_t var1, int8_t var2)       /* & */
        {
            return new int8_t(var1.var & var2.var);
        }
        public static int8_t operator |(int8_t var1, int8_t var2)       /* | */
        {
            return new int8_t(var1.var | var2.var);
        }
        public static int8_t operator ^(int8_t var1, int8_t var2)       /* ^ */
        {
            return new int8_t(var1.var ^ var2.var);
        }

        /* Comparison */
        public static bool operator >(int8_t var1, int8_t var2)         /* > */
        {
            return (var1.var > var2.var) ? true : false;
        }
        public static bool operator <(int8_t var1, int8_t var2)         /* < */
        {
            return (var1.var < var2.var) ? true : false;
        }
        public static bool operator <=(int8_t var1, int8_t var2)        /* <= */
        {
            return (var1.var <= var2.var) ? true : false;
        }
        public static bool operator >=(int8_t var1, int8_t var2)        /* >= */
        {
            return (var1.var >= var2.var) ? true : false;
        }
        public static bool operator ==(int8_t var1, int8_t var2)        /* == */
        {
            return (var1.var == var2.var) ? true : false;
        }
        public static bool operator !=(int8_t var1, int8_t var2)        /* != */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region uint8_t
        /* Assignment */
        public static implicit operator int8_t(uint8_t obj)
        {
            return new int8_t(obj);
        }

        /* Non-static math operations */
        public int8_t Add(uint8_t val)                                  /* Addition */
        {
            this.var = (sbyte)(this.var + val.var);
            return this;
        }
        public int8_t Substract(uint8_t val)                            /* Substraction */
        {
            this.var = (sbyte)(this.var - val.var);
            return this;
        }
        public int8_t Multiply(uint8_t val)                             /* Multiplication */
        {
            this.var = (sbyte)(this.var * val.var);
            return this;
        }
        public int8_t Divide(uint8_t val)                               /* Division */
        {
            this.var = (sbyte)(this.var / val.var);
            return this;
        }
        public int8_t Modulo(uint8_t val)                               /* Modulo */
        {
            this.var = (sbyte)(this.var % val.var);
            return this;
        }
        public int8_t AND(uint8_t val)                                  /* Bitwise AND operation */
        {
            this.var = (sbyte)(this.var & val.var);
            return this;
        }
        public int8_t OR(uint8_t val)                                   /* Bitwise OR operation */
        {
            this.var = (sbyte)((byte)this.var | val.var);
            return this;
        }
        public int8_t XOR(uint8_t val)                                  /* Bitwise XOR operation */
        {
            this.var = (sbyte)(this.var ^ val.var);
            return this;
        }

        /* Math */
        public static int8_t operator +(int8_t var1, uint8_t var2)      /* + */
        {
            return new int8_t(var1.var + var2.var);
        }
        public static int8_t operator -(int8_t var1, uint8_t var2)      /* - */
        {
            return new int8_t(var1.var - var2.var);
        }
        public static int8_t operator *(int8_t var1, uint8_t var2)      /* * */
        {
            return new int8_t(var1.var * var2.var);
        }
        public static int8_t operator /(int8_t var1, uint8_t var2)      /* / */
        {
            return new int8_t(var1.var * var2.var);
        }
        public static int8_t operator %(int8_t var1, uint8_t var2)      /* % */
        {
            return new int8_t(var1.var % var2.var);
        }
        public static int8_t operator &(int8_t var1, uint8_t var2)      /* & */
        {
            return new int8_t(var1.var & var2.var);
        }
        public static int8_t operator |(int8_t var1, uint8_t var2)      /* | */
        {
            return new int8_t((byte)var1.var | var2.var);
        }
        public static int8_t operator ^(int8_t var1, uint8_t var2)      /* ^ */
        {
            return new int8_t(var1.var ^ var2.var);
        }

        /* Comparison */
        public static bool operator >(int8_t var1, uint8_t var2)        /* > */
        {
            return (var1.var > var2.var) ? true : false;
        }
        public static bool operator <(int8_t var1, uint8_t var2)        /* < */
        {
            return (var1.var < var2.var) ? true : false;
        }
        public static bool operator <=(int8_t var1, uint8_t var2)       /* <= */
        {
            return (var1.var <= var2.var) ? true : false;
        }
        public static bool operator >=(int8_t var1, uint8_t var2)       /* >= */
        {
            return (var1.var >= var2.var) ? true : false;
        }
        public static bool operator ==(int8_t var1, uint8_t var2)       /* == */
        {
            return (var1.var == var2.var) ? true : false;
        }
        public static bool operator !=(int8_t var1, uint8_t var2)       /* != */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region int16_t
        /* Assignment */
        public static implicit operator int8_t(int16_t obj)
        {
            return new int8_t(obj);
        }

        /* Non-static math operations */
        public int8_t Add(int16_t val)                                  /* Addition */
        {
            this.var = (sbyte)(this.var + val.var);
            return this;
        }
        public int8_t Substract(int16_t val)                            /* Substraction */
        {
            this.var = (sbyte)(this.var - val.var);
            return this;
        }
        public int8_t Multiply(int16_t val)                             /* Multiplication */
        {
            this.var = (sbyte)(this.var * val.var);
            return this;
        }
        public int8_t Divide(int16_t val)                               /* Division */
        {
            this.var = (sbyte)(this.var / val.var);
            return this;
        }
        public int8_t Modulo(int16_t val)                               /* Modulo */
        {
            this.var = (sbyte)(this.var % val.var);
            return this;
        }
        public int8_t AND(int16_t val)                                  /* Bitwise AND operation */
        {
            this.var = (sbyte)(this.var & val.var);
            return this;
        }
        public int8_t OR(int16_t val)                                   /* Bitwise OR operation */
        {
            this.var = (sbyte)((short)this.var | val.var);
            return this;
        }
        public int8_t XOR(int16_t val)                                  /* Bitwise XOR operation */
        {
            this.var = (sbyte)(this.var ^ val.var);
            return this;
        }

        /* Math */
        public static int8_t operator +(int8_t var1, int16_t var2)      /* + */
        {
            return new int8_t(var1.var + var2.var);
        }
        public static int8_t operator -(int8_t var1, int16_t var2)      /* - */
        {
            return new int8_t(var1.var - var2.var);
        }
        public static int8_t operator *(int8_t var1, int16_t var2)      /* * */
        {
            return new int8_t(var1.var * var2.var);
        }
        public static int8_t operator /(int8_t var1, int16_t var2)      /* / */
        {
            return new int8_t(var1.var / var2.var);
        }
        public static int8_t operator %(int8_t var1, int16_t var2)      /* % */
        {
            return new int8_t(var1.var % var2.var);
        }
        public static int8_t operator &(int8_t var1, int16_t var2)      /* & */
        {
            return new int8_t(var1.var & var2.var);
        }
        public static int8_t operator |(int8_t var1, int16_t var2)      /* | */
        {
            return new int8_t((byte)var1.var | (ushort)var2.var);
        }
        public static int8_t operator ^(int8_t var1, int16_t var2)      /* ^ */
        {
            return new int8_t(var1.var ^ var2.var);
        }

        /* Comparison */
        public static bool operator >(int8_t var1, int16_t var2)        /* > */
        {
            return (var1.var > var2.var) ? true : false;
        }
        public static bool operator <(int8_t var1, int16_t var2)        /* < */
        {
            return (var1.var < var2.var) ? true : false;
        }
        public static bool operator <=(int8_t var1, int16_t var2)       /* <= */
        {
            return (var1.var <= var2.var) ? true : false;
        }
        public static bool operator >=(int8_t var1, int16_t var2)       /* >= */
        {
            return (var1.var >= var2.var) ? true : false;
        }
        public static bool operator ==(int8_t var1, int16_t var2)       /* == */
        {
            return (var1.var == var2.var) ? true : false;
        }
        public static bool operator !=(int8_t var1, int16_t var2)       /* != */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region uint16_t
        /* Assignment */
        public static implicit operator int8_t(uint16_t obj)
        {
            return new int8_t(obj);
        }

        /* Non-static math operations */
        public int8_t Add(uint16_t val)                                 /* Addition */
        {
            this.var = (sbyte)(this.var + val.var);
            return this;
        }
        public int8_t Substract(uint16_t val)                           /* Substraction */
        {
            this.var = (sbyte)(this.var - val.var);
            return this;
        }
        public int8_t Multiply(uint16_t val)                            /* Multiplication */
        {
            this.var = (sbyte)(this.var * val.var);
            return this;
        }
        public int8_t Divide(uint16_t val)                              /* Division */
        {
            this.var = (sbyte)(this.var / val.var);
            return this;
        }
        public int8_t Modulo(uint16_t val)                              /* Modulo */
        {
            this.var = (sbyte)(this.var % val.var);
            return this;
        }
        public int8_t AND(uint16_t val)                                 /* Bitwise AND operation */
        {
            this.var = (sbyte)(this.var & val.var);
            return this;
        }
        public int8_t OR(uint16_t val)                                  /* Bitwise OR operation */
        {
            this.var = (sbyte)((byte)this.var | val.var);
            return this;
        }
        public int8_t XOR(uint16_t val)                                 /* Bitwise XOR operation */
        {
            this.var = (sbyte)(this.var ^ val.var);
            return this;
        }

        /* Math */
        public static int8_t operator +(int8_t var1, uint16_t var2)     /* + */
        {
            return new int8_t(var1.var + var2.var);
        }
        public static int8_t operator -(int8_t var1, uint16_t var2)     /* - */
        {
            return new int8_t(var1.var - var2.var);
        }
        public static int8_t operator *(int8_t var1, uint16_t var2)     /* * */
        {
            return new int8_t(var1.var * var2.var);
        }
        public static int8_t operator /(int8_t var1, uint16_t var2)     /* / */
        {
            return new int8_t(var1.var / var2.var);
        }
        public static int8_t operator %(int8_t var1, uint16_t var2)     /* % */
        {
            return new int8_t(var1.var % var2.var);
        }
        public static int8_t operator &(int8_t var1, uint16_t var2)     /* & */
        {
            return new int8_t(var1.var & var2.var);
        }
        public static int8_t operator |(int8_t var1, uint16_t var2)     /* | */
        {
            return new int8_t((byte)var1.var | var2.var);
        }
        public static int8_t operator ^(int8_t var1, uint16_t var2)     /* ^ */
        {
            return new int8_t(var1.var ^ var2.var);
        }

        /* Comparison */
        public static bool operator >(int8_t var1, uint16_t var2)       /* > */
        {
            return (var1.var > var2.var) ? true : false;
        }
        public static bool operator <(int8_t var1, uint16_t var2)       /* < */
        {
            return (var1.var < var2.var) ? true : false;
        }
        public static bool operator <=(int8_t var1, uint16_t var2)      /* <= */
        {
            return (var1.var <= var2.var) ? true : false;
        }
        public static bool operator >=(int8_t var1, uint16_t var2)      /* >= */
        {
            return (var1.var >= var2.var) ? true : false;
        }
        public static bool operator ==(int8_t var1, uint16_t var2)      /* == */
        {
            return (var1.var == var2.var) ? true : false;
        }
        public static bool operator !=(int8_t var1, uint16_t var2)      /* != */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region int32_t
        /* Assignment */
        public static implicit operator int8_t(int32_t obj)
        {
            return new int8_t(obj);
        }

        /* Non-static math operations */
        public int8_t Add(int32_t val)                                  /* Addition */
        {
            this.var = (sbyte)(this.var + val.var);
            return this;
        }
        public int8_t Substract(int32_t val)                            /* Substraction */
        {
            this.var = (sbyte)(this.var - val.var);
            return this;
        }
        public int8_t Multiply(int32_t val)                             /* Multiplication */
        {
            this.var = (sbyte)(this.var * val.var);
            return this;
        }
        public int8_t Divide(int32_t val)                               /* Division */
        {
            this.var = (sbyte)(this.var / val.var);
            return this;
        }
        public int8_t Modulo(int32_t val)                               /* Modulo */
        {
            this.var = (sbyte)(this.var % val.var);
            return this;
        }
        public int8_t AND(int32_t val)                                  /* Bitwise AND operation */
        {
            this.var = (sbyte)(this.var & val.var);
            return this;
        }
        public int8_t OR(int32_t val)                                   /* Bitwise OR operation */
        {
            this.var = (sbyte)((byte)this.var | val.var);
            return this;
        }
        public int8_t XOR(int32_t val)                                  /* Bitwise XOR operation */
        {
            this.var = (sbyte)(this.var ^ val.var);
            return this;
        }

        /* Math */
        public static int8_t operator +(int8_t var1, int32_t var2)      /* + */
        {
            return new int8_t(var1.var + var2.var);
        }
        public static int8_t operator -(int8_t var1, int32_t var2)      /* - */
        {
            return new int8_t(var1.var - var2.var);
        }
        public static int8_t operator *(int8_t var1, int32_t var2)      /* * */
        {
            return new int8_t(var1.var * var2.var);
        }
        public static int8_t operator /(int8_t var1, int32_t var2)      /* / */
        {
            return new int8_t(var1.var / var2.var);
        }
        public static int8_t operator %(int8_t var1, int32_t var2)      /* % */
        {
            return new int8_t(var1.var % var2.var);
        }
        public static int8_t operator &(int8_t var1, int32_t var2)      /* & */
        {
            return new int8_t(var1.var & var2.var);
        }
        public static int8_t operator |(int8_t var1, int32_t var2)      /* | */
        {
            return new int8_t((byte)var1.var | var2.var);
        }
        public static int8_t operator ^(int8_t var1, int32_t var2)      /* ^ */
        {
            return new int8_t(var1.var ^ var2.var);
        }

        /* Comparison */
        public static bool operator >(int8_t var1, int32_t var2)        /* > */
        {
            return (var1.var > var2.var) ? true : false;
        }
        public static bool operator <(int8_t var1, int32_t var2)        /* < */
        {
            return (var1.var < var2.var) ? true : false;
        }
        public static bool operator <=(int8_t var1, int32_t var2)       /* <= */
        {
            return (var1.var <= var2.var) ? true : false;
        }
        public static bool operator >=(int8_t var1, int32_t var2)       /* >= */
        {
            return (var1.var >= var2.var) ? true : false;
        }
        public static bool operator ==(int8_t var1, int32_t var2)       /* == */
        {
            return (var1.var == var2.var) ? true : false;
        }
        public static bool operator !=(int8_t var1, int32_t var2)       /* != */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region uint32_t
        /* Assignment */
        public static implicit operator int8_t(uint32_t obj)
        {
            return new int8_t(obj);
        }

        /* Non-static math operations */
        public int8_t Add(uint32_t val)                                 /* Addition */
        {
            this.var = (sbyte)(this.var + val.var);
            return this;
        }
        public int8_t Substract(uint32_t val)                           /* Substraction */
        {
            this.var = (sbyte)(this.var - val.var);
            return this;
        }
        public int8_t Multiply(uint32_t val)                            /* Multiplication */
        {
            this.var = (sbyte)(this.var * val.var);
            return this;
        }
        public int8_t Divide(uint32_t val)                              /* Division */
        {
            this.var = (sbyte)(this.var / val.var);
            return this;
        }
        public int8_t Modulo(uint32_t val)                              /* Modulo */
        {
            this.var = (sbyte)(this.var % val.var);
            return this;
        }
        public int8_t AND(uint32_t val)                                 /* Bitwise AND operation */
        {
            this.var = (sbyte)(this.var & val.var);
            return this;
        }
        public int8_t OR(uint32_t val)                                  /* Bitwise OR operation */
        {
            this.var = (sbyte)((byte)this.var | val.var);
            return this;
        }
        public int8_t XOR(uint32_t val)                                 /* Bitwise XOR operation */
        {
            this.var = (sbyte)(this.var ^ val.var);
            return this;
        }

        /* Math */
        public static int8_t operator +(int8_t var1, uint32_t var2)     /* + */
        {
            return new int8_t(var1.var + var2.var);
        }
        public static int8_t operator -(int8_t var1, uint32_t var2)     /* - */
        {
            return new int8_t(var1.var - var2.var);
        }
        public static int8_t operator *(int8_t var1, uint32_t var2)     /* * */
        {
            return new int8_t(var1.var * var2.var);
        }
        public static int8_t operator /(int8_t var1, uint32_t var2)     /* / */
        {
            return new int8_t(var1.var / var2.var);
        }
        public static int8_t operator %(int8_t var1, uint32_t var2)     /* % */
        {
            return new int8_t(var1.var % var2.var);
        }
        public static int8_t operator &(int8_t var1, uint32_t var2)     /* & */
        {
            return new int8_t(var1.var & var2.var);
        }
        public static int8_t operator |(int8_t var1, uint32_t var2)     /* | */
        {
            return new int8_t((byte)var1.var |var2.var);
        }
        public static int8_t operator ^(int8_t var1, uint32_t var2)     /* ^ */
        {
            return new int8_t(var1.var ^ var2.var);
        }

        /* Comparison */
        public static bool operator >(int8_t var1, uint32_t var2)       /* > */
        {
            return (var1.var > var2.var) ? true : false;
        }
        public static bool operator <(int8_t var1, uint32_t var2)       /* < */
        {
            return (var1.var < var2.var) ? true : false;
        }
        public static bool operator <=(int8_t var1, uint32_t var2)      /* <= */
        {
            return (var1.var <= var2.var) ? true : false;
        }
        public static bool operator >=(int8_t var1, uint32_t var2)      /* >= */
        {
            return (var1.var >= var2.var) ? true : false;
        }
        public static bool operator ==(int8_t var1, uint32_t var2)      /* == */
        {
            return (var1.var == var2.var) ? true : false;
        }
        public static bool operator !=(int8_t var1, uint32_t var2)      /* != */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region int64_t
        /* Assignment */
        public static implicit operator int8_t(int64_t obj)
        {
            return new int8_t(obj);
        }

        /* Non-static math operations */
        public int8_t Add(int64_t val)                                  /* Addition */
        {
            this.var = (sbyte)(this.var + val.var);
            return this;
        }
        public int8_t Substract(int64_t val)                            /* Substraction */
        {
            this.var = (sbyte)(this.var - val.var);
            return this;
        }
        public int8_t Multiply(int64_t val)                             /* Multiplication */
        {
            this.var = (sbyte)(this.var * val.var);
            return this;
        }
        public int8_t Divide(int64_t val)                               /* Division */
        {
            this.var = (sbyte)(this.var / val.var);
            return this;
        }
        public int8_t Modulo(int64_t val)                               /* Modulo */
        {
            this.var = (sbyte)(this.var % val.var);
            return this;
        }
        public int8_t AND(int64_t val)                                  /* Bitwise AND operation */
        {
            this.var = (sbyte)(this.var & val.var);
            return this;
        }
        public int8_t OR(int64_t val)                                   /* Bitwise OR operation */
        {
            this.var = (sbyte)((byte)this.var | val.var);
            return this;
        }
        public int8_t XOR(int64_t val)                                  /* Bitwise XOR operation */
        {
            this.var = (sbyte)(this.var ^ val.var);
            return this;
        }

        /* Math */
        public static int8_t operator +(int8_t var1, int64_t var2)      /* + */
        {
            return new int8_t(var1.var + var2.var);
        }
        public static int8_t operator -(int8_t var1, int64_t var2)      /* - */
        {
            return new int8_t(var1.var - var2.var);
        }
        public static int8_t operator *(int8_t var1, int64_t var2)      /* * */
        {
            return new int8_t(var1.var * var2.var);
        }
        public static int8_t operator /(int8_t var1, int64_t var2)      /* / */
        {
            return new int8_t(var1.var / var2.var);
        }
        public static int8_t operator %(int8_t var1, int64_t var2)      /* % */
        {
            return new int8_t(var1.var % var2.var);
        }
        public static int8_t operator &(int8_t var1, int64_t var2)      /* & */
        {
            int8_t result = new int8_t(var1.var & var2.var);
            return new int8_t(var1.var & var2.var);
        }
        public static int8_t operator |(int8_t var1, int64_t var2)      /* | */
        {
            return new int8_t((byte)var1.var | (ulong)var2.var);
        }
        public static int8_t operator ^(int8_t var1, int64_t var2)      /* ^ */
        {
            return new int8_t(var1.var ^ var2.var);
        }

        /* Comparison */
        public static bool operator >(int8_t var1, int64_t var2)        /* > */
        {
            return (var1.var > var2.var) ? true : false;
        }
        public static bool operator <(int8_t var1, int64_t var2)        /* < */
        {
            return (var1.var < var2.var) ? true : false;
        }
        public static bool operator <=(int8_t var1, int64_t var2)       /* <= */
        {
            return (var1.var <= var2.var) ? true : false;
        }
        public static bool operator >=(int8_t var1, int64_t var2)       /* >= */
        {
            return (var1.var >= var2.var) ? true : false;
        }
        public static bool operator ==(int8_t var1, int64_t var2)       /* == */
        {
            return (var1.var == var2.var) ? true : false;
        }
        public static bool operator !=(int8_t var1, int64_t var2)       /* != */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region uint64_t
        /* Assignment */
        public static implicit operator int8_t(uint64_t obj)
        {
            return new int8_t(obj);
        }

        /* Non-static math operations */
        public int8_t Add(uint64_t val)                                 /* Addition */
        {
            this.var = (sbyte)((byte)this.var + val.var);
            return this;
        }
        public int8_t Substract(uint64_t val)                           /* Substraction */
        {
            this.var = (sbyte)((byte)this.var - val.var);
            return this;
        }
        public int8_t Multiply(uint64_t val)                            /* Multiplication */
        {
            this.var = (sbyte)((byte)this.var * val.var);
            return this;
        }
        public int8_t Divide(uint64_t val)                              /* Division */
        {
            this.var = (sbyte)((byte)this.var / val.var);
            return this;
        }
        public int8_t Modulo(uint64_t val)                              /* Modulo */
        {
            this.var = (sbyte)((byte)this.var % val.var);
            return this;
        }
        public int8_t AND(uint64_t val)                                 /* Bitwise AND operation */
        {
            this.var = (sbyte)((byte)this.var & val.var);
            return this;
        }
        public int8_t OR(uint64_t val)                                  /* Bitwise OR operation */
        {
            this.var = (sbyte)((byte)this.var | val.var);
            return this;
        }
        public int8_t XOR(uint64_t val)                                 /* Bitwise XOR operation */
        {
            this.var = (sbyte)((byte)this.var ^ val.var);
            return this;
        }

        /* Math */
        public static int8_t operator +(int8_t var1, uint64_t var2)     /* + */
        {
            return new int8_t((byte)var1.var + var2.var);
        }
        public static int8_t operator -(int8_t var1, uint64_t var2)     /* - */
        {
            return new int8_t((byte)var1.var - var2.var);
        }
        public static int8_t operator *(int8_t var1, uint64_t var2)     /* * */
        {
            return new int8_t((byte)var1.var * var2.var);
        }
        public static int8_t operator /(int8_t var1, uint64_t var2)     /* / */
        {
            return new int8_t((byte)var1.var / var2.var);
        }
        public static int8_t operator %(int8_t var1, uint64_t var2)     /* % */
        {
            return new int8_t((byte)var1.var / var2.var);
        }
        public static int8_t operator &(int8_t var1, uint64_t var2)     /* & */
        {
            return new int8_t((byte)var1.var & var2.var);
        }
        public static int8_t operator |(int8_t var1, uint64_t var2)     /* | */
        {
            return new int8_t((byte)var1.var | var2.var);
        }
        public static int8_t operator ^(int8_t var1, uint64_t var2)     /* ^ */
        {
            return new int8_t((byte)var1.var ^ var2.var);
        }

        /* Comparison */
        public static bool operator >(int8_t var1, uint64_t var2)       /* > */
        {
            return ((byte)var1.var > var2.var) ? true : false;
        }
        public static bool operator <(int8_t var1, uint64_t var2)       /* < */
        {
            return ((byte)var1.var < var2.var) ? true : false;
        }
        public static bool operator <=(int8_t var1, uint64_t var2)      /* <= */
        {
            return ((byte)var1.var <= var2.var) ? true : false;
        }
        public static bool operator >=(int8_t var1, uint64_t var2)      /* >= */
        {
            return ((byte)var1.var >= var2.var) ? true : false;
        }
        public static bool operator ==(int8_t var1, uint64_t var2)      /* == */
        {
            return ((byte)var1.var == var2.var) ? true : false;
        }
        public static bool operator !=(int8_t var1, uint64_t var2)      /* != */
        {
            return ((byte)var1.var != var2.var) ? true : false;
        }
        #endregion
        #endregion

        #region default types
        #region sbyte
        /* Assignment */
        public static implicit operator sbyte(int8_t obj)
        {
            return obj.var;
        }

        public static implicit operator int8_t(sbyte var)
        {
            return new int8_t(var);
        }

        /* Non-static math operations */
        public int8_t Add(sbyte val)                                    /* Addition */
        {                                                               
            this.var += val;                                            
            return this;                                                
        }                                                               
        public int8_t Substract(sbyte val)                              /* Substraction */
        {                                                               
            this.var -= val;                                            
            return this;                                                
        }                                                               
        public int8_t Multiply(sbyte val)                               /* Multiplication */
        {                                                               
            this.var *= val;                                            
            return this;                                                
        }                                                               
        public int8_t Divide(sbyte val)                                 /* Division */
        {                                                               
            this.var /= val;                                            
            return this;                                                
        }                                                               
        public int8_t Modulo(sbyte val)                                 /* Modulo */
        {                                                               
            this.var %= val;                                            
            return this;                                                
        }                                                               
        public int8_t AND(sbyte val)                                    /* Bitwise AND operation */
        {                                                               
            this.var &= val;                                            
            return this;                                                
        }                                                               
        public int8_t OR(sbyte val)                                     /* Bitwise OR operation */
        {                                                               
            this.var |= val;                                            
            return this;                                                
        }                                                               
        public int8_t XOR(sbyte val)                                    /* Bitwise XOR operation */
        {
            this.var ^= val;
            return this;
        }

        /* Math */
        public static int8_t operator +(int8_t var1, sbyte var2)        /* + */
        {
            return new int8_t(var1.var + var2);
        }
        public static int8_t operator -(int8_t var1, sbyte var2)        /* - */
        {
            return new int8_t(var1.var - var2);
        }
        public static int8_t operator *(int8_t var1, sbyte var2)        /* * */
        {
            return new int8_t(var1.var * var2);
        }
        public static int8_t operator /(int8_t var1, sbyte var2)        /* / */
        {
            return new int8_t(var1.var / var2);
        }
        public static int8_t operator %(int8_t var1, sbyte var2)        /* % */
        {
            return new int8_t(var1.var % var2);
        }
        public static int8_t operator &(int8_t var1, sbyte var2)        /* & */
        {
            return new int8_t(var1.var & var2);
        }
        public static int8_t operator |(int8_t var1, sbyte var2)        /* | */
        {
            return new int8_t(var1.var | var2);
        }
        public static int8_t operator ^(int8_t var1, sbyte var2)        /* != */
        {
            return new int8_t(var1.var ^ var2);
        }

        /* Comparison */
        public static bool operator >(int8_t var1, sbyte var2)          /* > */
        {
            return (var1.var > var2) ? true : false;
        }
        public static bool operator <(int8_t var1, sbyte var2)          /* < */
        {
            return (var1.var < var2) ? true : false;
        }
        public static bool operator <=(int8_t var1, sbyte var2)         /* <= */
        {
            return (var1.var <= var2) ? true : false;
        }
        public static bool operator >=(int8_t var1, sbyte var2)         /* >= */
        {
            return (var1.var >= var2) ? true : false;
        }
        public static bool operator ==(int8_t var1, sbyte var2)         /* == */
        {
            return (var1.var == var2) ? true : false;
        }
        public static bool operator !=(int8_t var1, sbyte var2)         /* != */
        {
            return (var1.var != var2) ? true : false;
        }
        #endregion
        #region byte
        /* Assignment */
        public static implicit operator byte(int8_t obj)
        {
            return (byte)obj.var;
        }

        public static implicit operator int8_t(byte var)
        {
            return new int8_t(var);
        }

        /* Non-static math operations */
        public int8_t Add(byte val)                                     /* Addition */
        {                                                               
            this.var += (sbyte)val;                                            
            return this;                                                
        }                                                               
        public int8_t Substract(byte val)                               /* Substraction */
        {                                                               
            this.var -= (sbyte)val;                                            
            return this;                                                
        }                                                               
        public int8_t Multiply(byte val)                                /* Multiplication */
        {                                                               
            this.var *= (sbyte)val;                                            
            return this;                                                
        }                                                               
        public int8_t Divide(byte val)                                  /* Division */
        {                                                               
            this.var /= (sbyte)val;                                            
            return this;                                                
        }                                                               
        public int8_t Modulo(byte val)                                  /* Modulo */
        {                                                               
            this.var %= (sbyte)val;                                            
            return this;                                                
        }                                                               
        public int8_t AND(byte val)                                     /* Bitwise AND operation */
        {                                                               
            this.var &= (sbyte)val;                                            
            return this;                                                
        }                                                               
        public int8_t OR(byte val)                                      /* Bitwise OR operation */
        {                                                               
            this.var |= (sbyte)val;                                            
            return this;                                                
        }                                                               
        public int8_t XOR(byte val)                                     /* Bitwise XOR operation */
        {
            this.var ^= (sbyte)val;
            return this;
        }

        /* Math */
        public static int8_t operator +(int8_t var1, byte var2)         /* + */
        {
            return new int8_t(var1.var + var2);
        }
        public static int8_t operator -(int8_t var1, byte var2)         /* - */
        {
            return new int8_t(var1.var - var2);
        }
        public static int8_t operator *(int8_t var1, byte var2)         /* * */
        {
            return new int8_t(var1.var * var2);
        }
        public static int8_t operator /(int8_t var1, byte var2)         /* / */
        {
            return new int8_t(var1.var / var2);
        }
        public static int8_t operator %(int8_t var1, byte var2)         /* % */
        {
            return new int8_t(var1.var % var2);
        }
        public static int8_t operator &(int8_t var1, byte var2)         /* & */
        {
            return new int8_t(var1.var & var2);
        }
        public static int8_t operator |(int8_t var1, byte var2)         /* | */
        {
            return new int8_t((byte)var1.var | var2);
        }
        public static int8_t operator ^(int8_t var1, byte var2)         /* != */
        {
            return new int8_t(var1.var ^ var2);
        }

        /* Comparison */
        public static bool operator >(int8_t var1, byte var2)           /* > */
        {
            return (var1.var > var2) ? true : false;
        }
        public static bool operator <(int8_t var1, byte var2)           /* < */
        {
            return (var1.var < var2) ? true : false;
        }
        public static bool operator <=(int8_t var1, byte var2)          /* <= */
        {
            return (var1.var <= var2) ? true : false;
        }
        public static bool operator >=(int8_t var1, byte var2)          /* >= */
        {
            return (var1.var >= var2) ? true : false;
        }
        public static bool operator ==(int8_t var1, byte var2)          /* == */
        {
            return (var1.var == var2) ? true : false;
        }
        public static bool operator !=(int8_t var1, byte var2)          /* != */
        {
            return (var1.var != var2) ? true : false;
        }
        #endregion
        #region short
        /* Assignment */
        public static implicit operator short(int8_t obj)
        {
            return obj.var;
        }

        public static implicit operator int8_t(short var)
        {
            return new int8_t(var);
        }

        /* Non-static math operations */
        public int8_t Add(short val)                                    /* Addition */
        {
            this.var += (sbyte)val;
            return this;
        }
        public int8_t Substract(short val)                              /* Substraction */
        {
            this.var -= (sbyte)val;
            return this;
        }
        public int8_t Multiply(short val)                               /* Multiplication */
        {
            this.var *= (sbyte)val;
            return this;
        }
        public int8_t Divide(short val)                                 /* Division */
        {
            this.var /= (sbyte)val;
            return this;
        }
        public int8_t Modulo(short val)                                 /* Modulo */
        {
            this.var %= (sbyte)val;
            return this;
        }
        public int8_t AND(short val)                                    /* Bitwise AND operation */
        {
            this.var &= (sbyte)val;
            return this;
        }
        public int8_t OR(short val)                                     /* Bitwise OR operation */
        {
            this.var |= (sbyte)val;
            return this;
        }
        public int8_t XOR(short val)                                    /* Bitwise XOR operation */
        {
            this.var ^= (sbyte)val;
            return this;
        }

        /* Math */
        public static int8_t operator +(int8_t var1, short var2)        /* + */
        {
            return new int8_t(var1.var + var2);
        }
        public static int8_t operator -(int8_t var1, short var2)        /* - */
        {
            return new int8_t(var1.var - var2);
        }
        public static int8_t operator *(int8_t var1, short var2)        /* * */
        {
            return new int8_t(var1.var * var2);
        }
        public static int8_t operator /(int8_t var1, short var2)        /* / */
        {
            return new int8_t(var1.var / var2);
        }
        public static int8_t operator %(int8_t var1, short var2)        /* % */
        {
            return new int8_t(var1.var % var2);
        }
        public static int8_t operator &(int8_t var1, short var2)        /* & */
        {
            return new int8_t(var1.var & var2);
        }
        public static int8_t operator |(int8_t var1, short var2)        /* | */
        {
            return new int8_t((byte)var1.var | (ushort)var2);
        }
        public static int8_t operator ^(int8_t var1, short var2)        /* != */
        {
            return new int8_t(var1.var ^ var2);
        }

        /* Comparison */
        public static bool operator >(int8_t var1, short var2)          /* > */
        {
            return (var1.var > var2) ? true : false;
        }
        public static bool operator <(int8_t var1, short var2)          /* < */
        {
            return (var1.var < var2) ? true : false;
        }
        public static bool operator <=(int8_t var1, short var2)         /* <= */
        {
            return (var1.var <= var2) ? true : false;
        }
        public static bool operator >=(int8_t var1, short var2)         /* >= */
        {
            return (var1.var >= var2) ? true : false;
        }
        public static bool operator ==(int8_t var1, short var2)         /* == */
        {
            return (var1.var == var2) ? true : false;
        }
        public static bool operator !=(int8_t var1, short var2)         /* != */
        {
            return (var1.var != var2) ? true : false;
        }
        #endregion
        #region ushort
        /* Assignment */
        public static implicit operator ushort(int8_t obj)
        {
            return (ushort)obj.var;
        }

        public static implicit operator int8_t(ushort var)
        {
            return new int8_t(var);
        }

        /* Non-static math operations */
        public int8_t Add(ushort val)                                   /* Addition */
        {
            this.var += (sbyte)val;
            return this;
        }
        public int8_t Substract(ushort val)                             /* Substraction */
        {
            this.var -= (sbyte)val;
            return this;
        }
        public int8_t Multiply(ushort val)                              /* Multiplication */
        {
            this.var *= (sbyte)val;
            return this;
        }
        public int8_t Divide(ushort val)                                /* Division */
        {
            this.var /= (sbyte)val;
            return this;
        }
        public int8_t Modulo(ushort val)                                /* Modulo */
        {
            this.var %= (sbyte)val;
            return this;
        }
        public int8_t AND(ushort val)                                   /* Bitwise AND operation */
        {
            this.var &= (sbyte)val;
            return this;
        }
        public int8_t OR(ushort val)                                    /* Bitwise OR operation */
        {
            this.var |= (sbyte)val;
            return this;
        }
        public int8_t XOR(ushort val)                                   /* Bitwise XOR operation */
        {
            this.var ^= (sbyte)val;
            return this;
        }

        /* Math */
        public static int8_t operator +(int8_t var1, ushort var2)       /* + */
        {
            return new int8_t(var1.var + var2);
        }
        public static int8_t operator -(int8_t var1, ushort var2)       /* - */
        {
            return new int8_t(var1.var - var2);
        }
        public static int8_t operator *(int8_t var1, ushort var2)       /* * */
        {
            return new int8_t(var1.var * var2);
        }
        public static int8_t operator /(int8_t var1, ushort var2)       /* / */
        {
            return new int8_t(var1.var / var2);
        }
        public static int8_t operator %(int8_t var1, ushort var2)       /* % */
        {
            return new int8_t(var1.var % var2);
        }
        public static int8_t operator &(int8_t var1, ushort var2)       /* & */
        {
            return new int8_t(var1.var & var2);
        }
        public static int8_t operator |(int8_t var1, ushort var2)       /* | */
        {
            return new int8_t((byte)var1.var | var2);
        }
        public static int8_t operator ^(int8_t var1, ushort var2)       /* != */
        {
            return new int8_t(var1.var ^ var2);
        }

        /* Comparison */
        public static bool operator >(int8_t var1, ushort var2)         /* > */
        {
            return (var1.var > var2) ? true : false;
        }
        public static bool operator <(int8_t var1, ushort var2)         /* < */
        {
            return (var1.var < var2) ? true : false;
        }
        public static bool operator <=(int8_t var1, ushort var2)        /* <= */
        {
            return (var1.var <= var2) ? true : false;
        }
        public static bool operator >=(int8_t var1, ushort var2)        /* >= */
        {
            return (var1.var >= var2) ? true : false;
        }
        public static bool operator ==(int8_t var1, ushort var2)        /* == */
        {
            return (var1.var == var2) ? true : false;
        }
        public static bool operator !=(int8_t var1, ushort var2)        /* != */
        {
            return (var1.var != var2) ? true : false;
        }
        #endregion
        #region int
        /* Assignment */
        public static implicit operator int(int8_t obj)
        {
            return obj.var;
        }

        public static implicit operator int8_t(int var)
        {
            return new int8_t(var);
        }

        /* Non-static math operations */
        public int8_t Add(int val)                                      /* Addition */
        {                                                               
            this.var += (sbyte)val;                                     
            return this;                                                
        }                                                               
        public int8_t Substract(int val)                                /* Substraction */
        {                                                               
            this.var -= (sbyte)val;                                     
            return this;                                                
        }                                                               
        public int8_t Multiply(int val)                                 /* Multiplication */
        {                                                               
            this.var *= (sbyte)val;                                     
            return this;                                                
        }                                                               
        public int8_t Divide(int val)                                   /* Division */
        {                                                               
            this.var /= (sbyte)val;                                     
            return this;                                                
        }                                                               
        public int8_t Modulo(int val)                                   /* Modulo */
        {                                                               
            this.var %= (sbyte)val;                                     
            return this;                                                
        }                                                               
        public int8_t AND(int val)                                      /* Bitwise AND operation */
        {                                                               
            this.var &= (sbyte)val;                                     
            return this;                                                
        }                                                               
        public int8_t OR(int val)                                       /* Bitwise OR operation */
        {                                                               
            this.var |= (sbyte)val;                                     
            return this;                                                
        }                                                               
        public int8_t XOR(int val)                                      /* Bitwise XOR operation */
        {
            this.var ^= (sbyte)val;
            return this;
        }

        /* Math */
        public static int8_t operator +(int8_t var1, int var2)          /* + */
        {
            return new int8_t(var1.var + var2);
        }
        public static int8_t operator -(int8_t var1, int var2)          /* - */
        {
            return new int8_t(var1.var - var2);
        }
        public static int8_t operator *(int8_t var1, int var2)          /* * */
        {
            return new int8_t(var1.var * var2);
        }
        public static int8_t operator /(int8_t var1, int var2)          /* / */
        {
            return new int8_t(var1.var / var2);
        }
        public static int8_t operator %(int8_t var1, int var2)          /* % */
        {
            return new int8_t(var1.var % var2);
        }
        public static int8_t operator &(int8_t var1, int var2)          /* & */
        {
            return new int8_t(var1.var & var2);
        }
        public static int8_t operator |(int8_t var1, int var2)          /* | */
        {
            return new int8_t((byte)var1.var | (uint)var2);
        }
        public static int8_t operator ^(int8_t var1, int var2)          /* ^ */
        {
            return new int8_t(var1.var ^ var2);
        }
        public static int8_t operator >>(int8_t var1, int var2)         /* >> */
        {
            return new int8_t(var1.var >> var2);
        }
        public static int8_t operator <<(int8_t var1, int var2)         /* << */
        {
            return new int8_t(var1.var << var2);
        }

        /* Comparison */
        public static bool operator >(int8_t var1, int var2)            /* > */
        {
            return (var1.var > var2) ? true : false;
        }
        public static bool operator <(int8_t var1, int var2)            /* < */
        {
            return (var1.var < var2) ? true : false;
        }
        public static bool operator <=(int8_t var1, int var2)           /* <= */
        {
            return (var1.var <= var2) ? true : false;
        }
        public static bool operator >=(int8_t var1, int var2)           /* >= */
        {
            return (var1.var >= var2) ? true : false;
        }
        public static bool operator ==(int8_t var1, int var2)           /* == */
        {
            return (var1.var == var2) ? true : false;
        }
        public static bool operator !=(int8_t var1, int var2)           /* != */
        {
            return (var1.var != var2) ? true : false;
        }
        #endregion
        #region uint
        /* Assignment */
        public static implicit operator uint(int8_t obj)
        {
            return (uint)obj.var;
        }

        public static implicit operator int8_t(uint var)
        {
            return new int8_t(var);
        }

        /* Non-static math operations */
        public int8_t Add(uint val)                                     /* Addition */
        {
            this.var += (sbyte)val;                                     
            return this;                                                
        }                                                               
        public int8_t Substract(uint val)                               /* Substraction */
        {                                                               
            this.var -= (sbyte)val;                                     
            return this;                                                
        }                                                               
        public int8_t Multiply(uint val)                                /* Multiplication */
        {                                                               
            this.var *= (sbyte)val;                                     
            return this;                                                
        }                                                               
        public int8_t Divide(uint val)                                  /* Division */
        {                                                               
            this.var /= (sbyte)val;                                     
            return this;                                                
        }                                                               
        public int8_t Modulo(uint val)                                  /* Modulo */
        {                                                               
            this.var %= (sbyte)val;                                     
            return this;                                                
        }                                                               
        public int8_t AND(uint val)                                     /* Bitwise AND operation */
        {                                                               
            this.var &= (sbyte)val;                                     
            return this;                                                
        }                                                               
        public int8_t OR(uint val)                                      /* Bitwise OR operation */
        {                                                               
            this.var |= (sbyte)val;                                     
            return this;                                                
        }                                                               
        public int8_t XOR(uint val)                                     /* Bitwise XOR operation */
        {
            this.var ^= (sbyte)val;
            return this;
        }

        /* Math */
        public static int8_t operator +(int8_t var1, uint var2)         /* + */
        {
            return new int8_t(var1.var + var2);
        }
        public static int8_t operator -(int8_t var1, uint var2)         /* - */
        {
            return new int8_t(var1.var - var2);
        }
        public static int8_t operator *(int8_t var1, uint var2)         /* * */
        {
            return new int8_t(var1.var * var2);
        }
        public static int8_t operator /(int8_t var1, uint var2)         /* / */
        {
            return new int8_t(var1.var / var2);
        }
        public static int8_t operator %(int8_t var1, uint var2)         /* % */
        {
            return new int8_t(var1.var % var2);
        }
        public static int8_t operator &(int8_t var1, uint var2)         /* & */
        {
            return new int8_t(var1.var & var2);
        }
        public static int8_t operator |(int8_t var1, uint var2)         /* | */
        {
            return new int8_t((byte)var1.var | var2);
        }
        public static int8_t operator ^(int8_t var1, uint var2)         /* != */
        {
            return new int8_t(var1.var ^ var2);
        }

        /* Comparison */
        public static bool operator >(int8_t var1, uint var2)           /* > */
        {
            return (var1.var > var2) ? true : false;
        }
        public static bool operator <(int8_t var1, uint var2)           /* < */
        {
            return (var1.var < var2) ? true : false;
        }
        public static bool operator <=(int8_t var1, uint var2)          /* <= */
        {
            return (var1.var <= var2) ? true : false;
        }
        public static bool operator >=(int8_t var1, uint var2)          /* >= */
        {
            return (var1.var >= var2) ? true : false;
        }
        public static bool operator ==(int8_t var1, uint var2)          /* == */
        {
            return (var1.var == var2) ? true : false;
        }
        public static bool operator !=(int8_t var1, uint var2)          /* != */
        {
            return (var1.var != var2) ? true : false;
        }
        #endregion
        #region long
        /* Assignment */
        public static implicit operator long(int8_t obj)
        {
            return obj.var;
        }

        public static implicit operator int8_t(long var)
        {
            return new int8_t(var);
        }

        /* Non-static math operations */
        public int8_t Add(long val)                                     /* Addition */
        {                                                               
            this.var += (sbyte)val;                                     
            return this;                                                
        }                                                               
        public int8_t Substract(long val)                               /* Substraction */
        {                                                               
            this.var -= (sbyte)val;                                     
            return this;                                                
        }                                                               
        public int8_t Multiply(long val)                                /* Multiplication */
        {                                                               
            this.var *= (sbyte)val;                                     
            return this;                                                
        }                                                               
        public int8_t Divide(long val)                                  /* Division */
        {                                                               
            this.var /= (sbyte)val;                                     
            return this;                                                
        }                                                               
        public int8_t Modulo(long val)                                  /* Modulo */
        {                                                               
            this.var %= (sbyte)val;                                     
            return this;                                                
        }                                                               
        public int8_t AND(long val)                                     /* Bitwise AND operation */
        {                                                               
            this.var &= (sbyte)val;                                     
            return this;                                                
        }                                                               
        public int8_t OR(long val)                                      /* Bitwise OR operation */
        {                                                               
            this.var |= (sbyte)val;                                     
            return this;                                                
        }                                                               
        public int8_t XOR(long val)                                     /* Bitwise XOR operation */
        {
            this.var ^= (sbyte)val;
            return this;
        }

        /* Math */
        public static int8_t operator +(int8_t var1, long var2)         /* + */
        {
            return new int8_t(var1.var + var2);
        }
        public static int8_t operator -(int8_t var1, long var2)         /* - */
        {
            return new int8_t(var1.var - var2);
        }
        public static int8_t operator *(int8_t var1, long var2)         /* * */
        {
            return new int8_t(var1.var * var2);
        }
        public static int8_t operator /(int8_t var1, long var2)         /* / */
        {
            return new int8_t(var1.var / var2);
        }
        public static int8_t operator %(int8_t var1, long var2)         /* % */
        {
            return new int8_t(var1.var % var2);
        }
        public static int8_t operator &(int8_t var1, long var2)         /* & */
        {
            return new int8_t(var1.var & var2);
        }
        public static int8_t operator |(int8_t var1, long var2)         /* | */
        {
            return new int8_t((byte)var1.var | var2);
        }
        public static int8_t operator ^(int8_t var1, long var2)         /* != */
        {
            return new int8_t(var1.var ^ var2);
        }

        /* Comparison */
        public static bool operator >(int8_t var1, long var2)           /* > */
        {
            return (var1.var > var2) ? true : false;
        }
        public static bool operator <(int8_t var1, long var2)           /* < */
        {
            return (var1.var < var2) ? true : false;
        }
        public static bool operator <=(int8_t var1, long var2)          /* <= */
        {
            return (var1.var <= var2) ? true : false;
        }
        public static bool operator >=(int8_t var1, long var2)          /* >= */
        {
            return (var1.var >= var2) ? true : false;
        }
        public static bool operator ==(int8_t var1, long var2)          /* == */
        {
            return (var1.var == var2) ? true : false;
        }
        public static bool operator !=(int8_t var1, long var2)          /* != */
        {
            return (var1.var != var2) ? true : false;
        }
        #endregion
        #region ulong
        /* Assignment */
        public static implicit operator ulong(int8_t obj)
        {
            return (ulong)obj.var;
        }

        public static implicit operator int8_t(ulong var)
        {
            return new int8_t(var);
        }

        /* Non-static math operations */
        public int8_t Add(ulong val)                                    /* Addition */
        {
            this.var += (sbyte)val;
            return this;
        }
        public int8_t Substract(ulong val)                              /* Substraction */
        {
            this.var -= (sbyte)val;
            return this;
        }
        public int8_t Multiply(ulong val)                               /* Multiplication */
        {
            this.var *= (sbyte)val;
            return this;
        }
        public int8_t Divide(ulong val)                                 /* Division */
        {
            this.var /= (sbyte)val;
            return this;
        }
        public int8_t Modulo(ulong val)                                 /* Modulo */
        {
            this.var %= (sbyte)val;
            return this;
        }
        public int8_t AND(ulong val)                                    /* Bitwise AND operation */
        {
            this.var &= (sbyte)val;
            return this;
        }
        public int8_t OR(ulong val)                                     /* Bitwise OR operation */
        {
            this.var |= (sbyte)val;
            return this;
        }
        public int8_t XOR(ulong val)                                    /* Bitwise XOR operation */
        {
            this.var ^= (sbyte)val;
            return this;
        }

        /* Math */
        public static int8_t operator +(int8_t var1, ulong var2)        /* + */
        {
            return new int8_t((byte)var1.var + var2);
        }
        public static int8_t operator -(int8_t var1, ulong var2)        /* - */
        {
            return new int8_t((byte)var1.var - var2);
        }
        public static int8_t operator *(int8_t var1, ulong var2)        /* * */
        {
            return new int8_t((byte)var1.var * var2);
        }
        public static int8_t operator /(int8_t var1, ulong var2)        /* / */
        {
            return new int8_t((byte)var1.var / var2);
        }
        public static int8_t operator %(int8_t var1, ulong var2)        /* % */
        {
            return new int8_t((byte)var1.var % var2);
        }
        public static int8_t operator &(int8_t var1, ulong var2)        /* & */
        {
            return new int8_t((byte)var1.var & var2);
        }
        public static int8_t operator |(int8_t var1, ulong var2)        /* | */
        {
            return new int8_t((byte)var1.var | var2);
        }
        public static int8_t operator ^(int8_t var1, ulong var2)        /* != */
        {
            return new int8_t((byte)var1.var ^ var2);
        }

        /* Comparison */
        public static bool operator >(int8_t var1, ulong var2)          /* > */
        {
            return ((byte)var1.var > var2) ? true : false;
        }
        public static bool operator <(int8_t var1, ulong var2)          /* < */
        {
            return ((byte)var1.var < var2) ? true : false;
        }
        public static bool operator <=(int8_t var1, ulong var2)         /* <= */
        {
            return ((byte)var1.var <= var2) ? true : false;
        }
        public static bool operator >=(int8_t var1, ulong var2)         /* >= */
        {
            return ((byte)var1.var >= var2) ? true : false;
        }
        public static bool operator ==(int8_t var1, ulong var2)         /* == */
        {
            return ((byte)var1.var == var2) ? true : false;
        }
        public static bool operator !=(int8_t var1, ulong var2)         /* != */
        {
            return ((byte)var1.var != var2) ? true : false;
        }
        #endregion

        #region float
        /* Non-static math operations */
        public int8_t Add(float val)                                    /* Addition */
        {
            this.var += System.Convert.ToSByte(System.Math.Truncate(val));
            return this;
        }
        public int8_t Substract(float val)                              /* Substraction */
        {
            this.var -= System.Convert.ToSByte(System.Math.Truncate(val));
            return this;
        }
        public int8_t Multiply(float val)                               /* Multiplication */
        {
            this.var *= System.Convert.ToSByte(System.Math.Truncate(val));
            return this;
        }
        public int8_t Divide(float val)                                 /* Division */
        {
            this.var /= System.Convert.ToSByte(System.Math.Truncate(val));
            return this;
        }
        public int8_t Modulo(float val)                                 /* Modulo */
        {
            this.var %= System.Convert.ToSByte(System.Math.Truncate(val));
            return this;
        }
        public int8_t AND(float val)                                    /* Bitwise AND operation */
        {
            throw new System.ArgumentException(System.String.Format("AND operation cannot be applied with float parameter {0}", val));
        }
        public int8_t OR(float val)                                     /* Bitwise OR operation */
        {
            throw new System.ArgumentException(System.String.Format("OR operation cannot be applied with float parameter {0}", val));
        }
        public int8_t XOR(float val)                                    /* Bitwise XOR operation */
        {
            throw new System.ArgumentException(System.String.Format("XOR operation cannot be applied with float parameter {0}", val));
        }

        /* Math */
        public static int8_t operator +(int8_t var1, float var2)        /* + */
        {
            return new int8_t(var1.var + var2);
        }
        public static int8_t operator -(int8_t var1, float var2)        /* - */
        {
            return new int8_t(var1.var - var2);
        }
        public static int8_t operator *(int8_t var1, float var2)        /* * */
        {
            return new int8_t(var1.var * var2);
        }
        public static int8_t operator /(int8_t var1, float var2)        /* / */
        {
            return new int8_t(var1.var / var2);
        }
        public static int8_t operator %(int8_t var1, float var2)        /* % */
        {
            return new int8_t(var1.var % var2);
        }
        public static int8_t operator &(int8_t var1, float var2)        /* & */
        {
            throw new System.ArgumentException(System.String.Format("& operator cannot be applied with float parameter {0}", var2));
        }
        public static int8_t operator |(int8_t var1, float var2)        /* | */
        {
            throw new System.ArgumentException(System.String.Format("| operator cannot be applied with float parameter {0}", var2));
        }
        public static int8_t operator ^(int8_t var1, float var2)        /* != */
        {
            throw new System.ArgumentException(System.String.Format("^ operator cannot be applied with float parameter {0}", var2));
        }

        /* Comparison */
        public static bool operator >(int8_t var1, float var2)          /* > */
        {
            return (var1.var > var2) ? true : false;
        }
        public static bool operator <(int8_t var1, float var2)          /* < */
        {
            return (var1.var < var2) ? true : false;
        }
        public static bool operator <=(int8_t var1, float var2)         /* <= */
        {
            return (var1.var <= var2) ? true : false;
        }
        public static bool operator >=(int8_t var1, float var2)         /* >= */
        {
            return (var1.var >= var2) ? true : false;
        }
        public static bool operator ==(int8_t var1, float var2)         /* == */
        {
            return (var1.var == var2) ? true : false;
        }
        public static bool operator !=(int8_t var1, float var2)         /* != */
        {
            return (var1.var != var2) ? true : false;
        }
        #endregion
        #region double
        /* Non-static math operations */
        public int8_t Add(double val)                                   /* Addition */
        {
            this.var += System.Convert.ToSByte(System.Math.Truncate(val));
            return this;
        }
        public int8_t Substract(double val)                             /* Substraction */
        {
            this.var -= System.Convert.ToSByte(System.Math.Truncate(val));
            return this;
        }
        public int8_t Multiply(double val)                              /* Multiplication */
        {
            this.var *= System.Convert.ToSByte(System.Math.Truncate(val));
            return this;
        }
        public int8_t Divide(double val)                                /* Division */
        {
            this.var /= System.Convert.ToSByte(System.Math.Truncate(val));
            return this;
        }
        public int8_t Modulo(double val)                                /* Modulo */
        {
            this.var %= System.Convert.ToSByte(System.Math.Truncate(val));
            return this;
        }
        public int8_t AND(double val)                                   /* Bitwise AND operation */
        {
            throw new System.ArgumentException(System.String.Format("AND operation cannot be applied with double parameter {0}", val));
        }
        public int8_t OR(double val)                                    /* Bitwise OR operation */
        {
            throw new System.ArgumentException(System.String.Format("OR operation cannot be applied with double parameter {0}", val));
        }
        public int8_t XOR(double val)                                   /* Bitwise XOR operation */
        {
            throw new System.ArgumentException(System.String.Format("XOR operation cannot be applied with double parameter {0}", val));
        }

        /* Math */
        public static int8_t operator +(int8_t var1, double var2)       /* + */
        {
            return new int8_t(var1.var + var2);
        }
        public static int8_t operator -(int8_t var1, double var2)       /* - */
        {
            return new int8_t(var1.var - var2);
        }
        public static int8_t operator *(int8_t var1, double var2)       /* * */
        {
            return new int8_t(var1.var * var2);
        }
        public static int8_t operator /(int8_t var1, double var2)       /* / */
        {
            return new int8_t(var1.var / var2);
        }
        public static int8_t operator %(int8_t var1, double var2)       /* % */
        {
            return new int8_t(var1.var % var2);
        }
        public static int8_t operator &(int8_t var1, double var2)       /* & */
        {
            throw new System.ArgumentException(System.String.Format("& operator cannot be applied with double parameter {0}", var2));
        }
        public static int8_t operator |(int8_t var1, double var2)       /* | */
        {
            throw new System.ArgumentException(System.String.Format("| operator cannot be applied with double parameter {0}", var2));
        }
        public static int8_t operator ^(int8_t var1, double var2)       /* != */
        {
            throw new System.ArgumentException(System.String.Format("^ operator cannot be applied with double parameter {0}", var2));
        }

        /* Comparison */
        public static bool operator >(int8_t var1, double var2)         /* > */
        {
            return (var1.var > var2) ? true : false;
        }
        public static bool operator <(int8_t var1, double var2)         /* < */
        {
            return (var1.var < var2) ? true : false;
        }
        public static bool operator <=(int8_t var1, double var2)        /* <= */
        {
            return (var1.var <= var2) ? true : false;
        }
        public static bool operator >=(int8_t var1, double var2)        /* >= */
        {
            return (var1.var >= var2) ? true : false;
        }
        public static bool operator ==(int8_t var1, double var2)        /* == */
        {
            return (var1.var == var2) ? true : false;
        }
        public static bool operator !=(int8_t var1, double var2)        /* != */
        {
            return (var1.var != var2) ? true : false;
        }
        #endregion
        #endregion
        #endregion

        #region specials
        public override bool Equals(object obj)
        {
            return (obj is int8_t) ? this == (int8_t)obj : false;
        }
        public override int GetHashCode()
        {
            return var;
        }
        public override string ToString()
        {
            return var.ToString();
        }
        
        public int8_t Increment()
        {
            this.var++;
            return this;
        }
        public int8_t Decrement()
        {
            this.var--;
            return this;
        }
        #endregion
    }

    /****************************** uint8_t **********************************/
    class uint8_t
    {
        public byte var = 0;

        #region Constructors
        public uint8_t()                { var = 0; }
        public uint8_t(byte value)      { var = value; }
        public uint8_t(sbyte value)     { var = (byte)value; }
        public uint8_t(short value)     { var = (byte)value; }
        public uint8_t(ushort value)    { var = (byte)value; }
        public uint8_t(int value)       { var = (byte)value; }
        public uint8_t(uint value)      { var = (byte)value; }
        public uint8_t(long value)      { var = (byte)value; }
        public uint8_t(ulong value)     { var = (byte)value; }
        public uint8_t(float value)     { var = System.Convert.ToByte(System.Math.Truncate(value)); }
        public uint8_t(double value)    { var = System.Convert.ToByte(System.Math.Truncate(value)); }
        public uint8_t(int8_t value)    { var = (byte)value.var; }
        public uint8_t(uint8_t value)   { var = value.var; }
        public uint8_t(int16_t value)   { var = (byte)value.var; }
        public uint8_t(uint16_t value)  { var = (byte)value.var; }
        public uint8_t(int32_t value)   { var = (byte)value.var; }
        public uint8_t(uint32_t value)  { var = (byte)value.var; }
        public uint8_t(int64_t value)   { var = (byte)value.var; }
        public uint8_t(uint64_t value)  { var = (byte)value.var; }
        #endregion

        #region types
        #region new types
        #region int8_t
        /* Assignment */
        public static implicit operator uint8_t(int8_t obj)
        {
            return new uint8_t(obj);
        }

        /* Non-static math operations */
        public uint8_t Add(int8_t val)                                  /* Addition */
        {
            this.var = (byte)(this.var + val.var);
            return this;
        }
        public uint8_t Substract(int8_t val)                            /* Substraction */
        {
            this.var = (byte)(this.var - val.var);
            return this;
        }
        public uint8_t Multiply(int8_t val)                             /* Multiplication */
        {
            this.var = (byte)(this.var * val.var);
            return this;
        }
        public uint8_t Divide(int8_t val)                               /* Division */
        {
            this.var = (byte)(this.var / val.var);
            return this;
        }
        public uint8_t Modulo(int8_t val)                               /* Modulo */
        {
            this.var = (byte)(this.var % val.var);
            return this;
        }
        public uint8_t AND(int8_t val)                                  /* Bitwise AND operation */
        {
            this.var = (byte)(this.var & val.var);
            return this;
        }
        public uint8_t OR(int8_t val)                                   /* Bitwise OR operation */
        {
            this.var = (byte)(this.var | (byte)val.var);
            return this;
        }
        public uint8_t XOR(int8_t val)                                  /* Bitwise XOR operation */
        {
            this.var = (byte)(this.var ^ val.var);
            return this;
        }

        /* Math */
        public static uint8_t operator +(uint8_t var1, int8_t var2)     /* + */
        {
            return new uint8_t(var1.var + var2.var);
        }
        public static uint8_t operator -(uint8_t var1, int8_t var2)     /* - */
        {
            return new uint8_t(var1.var - var2.var);
        }
        public static uint8_t operator *(uint8_t var1, int8_t var2)     /* * */
        {
            return new uint8_t(var1.var * var2.var);
        }
        public static uint8_t operator /(uint8_t var1, int8_t var2)     /* / */
        {
            return new uint8_t(var1.var / var2.var);
        }
        public static uint8_t operator %(uint8_t var1, int8_t var2)     /* % */
        {
            return new uint8_t(var1.var % var2.var);
        }
        public static uint8_t operator &(uint8_t var1, int8_t var2)     /* & */
        {
            return new uint8_t(var1.var & var2.var);
        }
        public static uint8_t operator |(uint8_t var1, int8_t var2)     /* | */
        {
            return new uint8_t(var1.var | (byte)var2.var);
        }
        public static uint8_t operator ^(uint8_t var1, int8_t var2)     /* ^ */
        {
            return new uint8_t(var1.var ^ var2.var);
        }

        /* Comparison */
        public static bool operator >(uint8_t var1, int8_t var2)        /* > */
        {
            return (var1.var > var2.var) ? true : false;
        }
        public static bool operator <(uint8_t var1, int8_t var2)        /* < */
        {
            return (var1.var < var2.var) ? true : false;
        }
        public static bool operator <=(uint8_t var1, int8_t var2)       /* <= */
        {
            return (var1.var <= var2.var) ? true : false;
        }
        public static bool operator >=(uint8_t var1, int8_t var2)       /* >= */
        {
            return (var1.var >= var2.var) ? true : false;
        }
        public static bool operator ==(uint8_t var1, int8_t var2)       /* == */
        {
            return (var1.var == var2.var) ? true : false;
        }
        public static bool operator !=(uint8_t var1, int8_t var2)       /* != */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region uint8_t
        /* Unary operators */
        public static uint8_t operator ++(uint8_t obj)                  /* ++ */
        {
            obj.Increment();
            return obj;
        }
        public static uint8_t operator --(uint8_t obj)                  /* -- */
        {
            obj.Decrement();
            return obj;
        }
        public static uint8_t operator -(uint8_t obj)                   /* - (unary) */
        {
            return new uint8_t(-obj.var);
        }
        public static uint8_t operator +(uint8_t obj)                   /* + (unary) */
        {
            return new uint8_t(obj);
        }
        public static uint8_t operator ~(uint8_t obj)                   /* ~ */
        {
            return new uint8_t(~obj.var);
        }

        /* Non-static math operations */
        public uint8_t Add(uint8_t val)                                 /* Addition */
        {
            this.var += val.var;
            return this;
        }
        public uint8_t Substract(uint8_t val)                           /* Substraction */
        {
            this.var -= val.var;
            return this;
        }
        public uint8_t Multiply(uint8_t val)                            /* Multiplication */
        {
            this.var *= val.var;
            return this;
        }
        public uint8_t Divide(uint8_t val)                              /* Division */
        {
            this.var /= val.var;
            return this;
        }
        public uint8_t Modulo(uint8_t val)                              /* Modulo */
        {
            this.var %= val.var;
            return this;
        }
        public uint8_t AND(uint8_t val)                                 /* Bitwise AND operation */
        {
            this.var &= val.var;
            return this;
        }
        public uint8_t OR(uint8_t val)                                  /* Bitwise OR operation */
        {
            this.var |= val.var;
            return this;
        }
        public uint8_t XOR(uint8_t val)                                 /* Bitwise XOR operation */
        {
            this.var ^= val.var;
            return this;
        }

        /* Math */
        public static uint8_t operator +(uint8_t var1, uint8_t var2)    /* + */
        {
            return new uint8_t(var1.var + var2.var);
        }
        public static uint8_t operator -(uint8_t var1, uint8_t var2)    /* - */
        {
            return new uint8_t(var1.var - var2.var);
        }
        public static uint8_t operator *(uint8_t var1, uint8_t var2)    /* * */
        {
            return new uint8_t(var1.var * var2.var);
        }
        public static uint8_t operator /(uint8_t var1, uint8_t var2)    /* / */
        {
            return new uint8_t(var1.var / var2.var);
        }
        public static uint8_t operator %(uint8_t var1, uint8_t var2)    /* % */
        {
            return new uint8_t(var1.var % var2.var);
        }
        public static uint8_t operator &(uint8_t var1, uint8_t var2)    /* & */
        {
            return new uint8_t(var1.var & var2.var);
        }
        public static uint8_t operator |(uint8_t var1, uint8_t var2)    /* | */
        {
            return new uint8_t(var1.var | var2.var);
        }
        public static uint8_t operator ^(uint8_t var1, uint8_t var2)    /* ^ */
        {
            return new uint8_t(var1.var ^ var2.var);
        }

        /* Comparison */
        public static bool operator >(uint8_t var1, uint8_t var2)       /* > */
        {
            return (var1.var > var2.var) ? true : false;
        }
        public static bool operator <(uint8_t var1, uint8_t var2)       /* < */
        {
            return (var1.var < var2.var) ? true : false;
        }
        public static bool operator <=(uint8_t var1, uint8_t var2)      /* <= */
        {
            return (var1.var <= var2.var) ? true : false;
        }
        public static bool operator >=(uint8_t var1, uint8_t var2)      /* >= */
        {
            return (var1.var >= var2.var) ? true : false;
        }
        public static bool operator ==(uint8_t var1, uint8_t var2)      /* == */
        {
            return (var1.var == var2.var) ? true : false;
        }
        public static bool operator !=(uint8_t var1, uint8_t var2)      /* != */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region int16_t
        /* Assignment */
        public static implicit operator uint8_t(int16_t obj)
        {
            return new uint8_t(obj);
        }

        /* Non-static math operations */
        public uint8_t Add(int16_t val)                                 /* Addition */
        {
            this.var = (byte)(this.var + val.var);
            return this;
        }
        public uint8_t Substract(int16_t val)                           /* Substraction */
        {
            this.var = (byte)(this.var - val.var);
            return this;
        }
        public uint8_t Multiply(int16_t val)                            /* Multiplication */
        {
            this.var = (byte)(this.var * val.var);
            return this;
        }
        public uint8_t Divide(int16_t val)                              /* Division */
        {
            this.var = (byte)(this.var / val.var);
            return this;
        }
        public uint8_t Modulo(int16_t val)                              /* Modulo */
        {
            this.var = (byte)(this.var % val.var);
            return this;
        }
        public uint8_t AND(int16_t val)                                 /* Bitwise AND operation */
        {
            this.var = (byte)(this.var & val.var);
            return this;
        }
        public uint8_t OR(int16_t val)                                  /* Bitwise OR operation */
        {
            this.var = (byte)(this.var | (byte)val.var);
            return this;
        }
        public uint8_t XOR(int16_t val)                                 /* Bitwise XOR operation */
        {
            this.var = (byte)(this.var ^ val.var);
            return this;
        }

        /* Math */
        public static uint8_t operator +(uint8_t var1, int16_t var2)    /* + */
        {
            return new uint8_t(var1.var + var2.var);
        }
        public static uint8_t operator -(uint8_t var1, int16_t var2)    /* - */
        {
            return new uint8_t(var1.var - var2.var);
        }
        public static uint8_t operator *(uint8_t var1, int16_t var2)    /* * */
        {
            return new uint8_t(var1.var * var2.var);
        }
        public static uint8_t operator /(uint8_t var1, int16_t var2)    /* / */
        {
            return new uint8_t(var1.var / var2.var);
        }
        public static uint8_t operator %(uint8_t var1, int16_t var2)    /* % */
        {
            return new uint8_t(var1.var % var2.var);
        }
        public static uint8_t operator &(uint8_t var1, int16_t var2)    /* & */
        {
            return new uint8_t(var1.var & var2.var);
        }
        public static uint8_t operator |(uint8_t var1, int16_t var2)    /* | */
        {
            return new uint8_t(var1.var | (ushort)var2.var);
        }
        public static uint8_t operator ^(uint8_t var1, int16_t var2)    /* ^ */
        {
            return new uint8_t(var1.var ^ var2.var);
        }

        /* Comparison */
        public static bool operator >(uint8_t var1, int16_t var2)       /* > */
        {
            return (var1.var > var2.var) ? true : false;
        }
        public static bool operator <(uint8_t var1, int16_t var2)       /* < */
        {
            return (var1.var < var2.var) ? true : false;
        }
        public static bool operator <=(uint8_t var1, int16_t var2)      /* <= */
        {
            return (var1.var <= var2.var) ? true : false;
        }
        public static bool operator >=(uint8_t var1, int16_t var2)      /* >= */
        {
            return (var1.var >= var2.var) ? true : false;
        }
        public static bool operator ==(uint8_t var1, int16_t var2)      /* == */
        {
            return (var1.var == var2.var) ? true : false;
        }
        public static bool operator !=(uint8_t var1, int16_t var2)      /* != */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region uint16_t
        /* Assignment */
        public static implicit operator uint8_t(uint16_t obj)
        {
            return new uint8_t(obj);
        }

        /* Non-static math operations */
        public uint8_t Add(uint16_t val)                                /* Addition */
        {
            this.var = (byte)(this.var + val.var);
            return this;
        }
        public uint8_t Substract(uint16_t val)                          /* Substraction */
        {
            this.var = (byte)(this.var - val.var);
            return this;
        }
        public uint8_t Multiply(uint16_t val)                           /* Multiplication */
        {
            this.var = (byte)(this.var * val.var);
            return this;
        }
        public uint8_t Divide(uint16_t val)                             /* Division */
        {
            this.var = (byte)(this.var / val.var);
            return this;
        }
        public uint8_t Modulo(uint16_t val)                             /* Modulo */
        {
            this.var = (byte)(this.var % val.var);
            return this;
        }
        public uint8_t AND(uint16_t val)                                /* Bitwise AND operation */
        {
            this.var = (byte)(this.var & val.var);
            return this;
        }
        public uint8_t OR(uint16_t val)                                 /* Bitwise OR operation */
        {
            this.var = (byte)(this.var | (byte)val.var);
            return this;
        }
        public uint8_t XOR(uint16_t val)                                /* Bitwise XOR operation */
        {
            this.var = (byte)(this.var ^ val.var);
            return this;
        }

        /* Math */
        public static uint8_t operator +(uint8_t var1, uint16_t var2)   /* + */
        {
            return new uint8_t(var1.var + var2.var);
        }
        public static uint8_t operator -(uint8_t var1, uint16_t var2)   /* - */
        {
            return new uint8_t(var1.var - var2.var);
        }
        public static uint8_t operator *(uint8_t var1, uint16_t var2)   /* * */
        {
            return new uint8_t(var1.var * var2.var);
        }
        public static uint8_t operator /(uint8_t var1, uint16_t var2)   /* / */
        {
            return new uint8_t(var1.var / var2.var);
        }
        public static uint8_t operator %(uint8_t var1, uint16_t var2)   /* % */
        {
            return new uint8_t(var1.var % var2.var);
        }
        public static uint8_t operator &(uint8_t var1, uint16_t var2)   /* & */
        {
            return new uint8_t(var1.var & var2.var);
        }
        public static uint8_t operator |(uint8_t var1, uint16_t var2)   /* | */
        {
            return new uint8_t(var1.var | var2.var);
        }
        public static uint8_t operator ^(uint8_t var1, uint16_t var2)   /* ^ */
        {
            return new uint8_t(var1.var ^ var2.var);
        }

        /* Comparison */
        public static bool operator >(uint8_t var1, uint16_t var2)      /* > */
        {
            return (var1.var > var2.var) ? true : false;
        }
        public static bool operator <(uint8_t var1, uint16_t var2)      /* < */
        {
            return (var1.var < var2.var) ? true : false;
        }
        public static bool operator <=(uint8_t var1, uint16_t var2)     /* <= */
        {
            return (var1.var <= var2.var) ? true : false;
        }
        public static bool operator >=(uint8_t var1, uint16_t var2)     /* >= */
        {
            return (var1.var >= var2.var) ? true : false;
        }
        public static bool operator ==(uint8_t var1, uint16_t var2)     /* == */
        {
            return (var1.var == var2.var) ? true : false;
        }
        public static bool operator !=(uint8_t var1, uint16_t var2)     /* != */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region int32_t
        /* Assignment */
        public static implicit operator uint8_t(int32_t obj)
        {
            return new uint8_t(obj);
        }

        /* Non-static math operations */
        public uint8_t Add(int32_t val)                                 /* Addition */
        {
            this.var = (byte)(this.var + val.var);
            return this;
        }
        public uint8_t Substract(int32_t val)                           /* Substraction */
        {
            this.var = (byte)(this.var - val.var);
            return this;
        }
        public uint8_t Multiply(int32_t val)                            /* Multiplication */
        {
            this.var = (byte)(this.var * val.var);
            return this;
        }
        public uint8_t Divide(int32_t val)                              /* Division */
        {
            this.var = (byte)(this.var / val.var);
            return this;
        }
        public uint8_t Modulo(int32_t val)                              /* Modulo */
        {
            this.var = (byte)(this.var % val.var);
            return this;
        }
        public uint8_t AND(int32_t val)                                 /* Bitwise AND operation */
        {
            this.var = (byte)(this.var & val.var);
            return this;
        }
        public uint8_t OR(int32_t val)                                  /* Bitwise OR operation */
        {
            this.var = (byte)(this.var | (byte)val.var);
            return this;
        }
        public uint8_t XOR(int32_t val)                                 /* Bitwise XOR operation */
        {
            this.var = (byte)(this.var ^ val.var);
            return this;
        }

        /* Math */
        public static uint8_t operator +(uint8_t var1, int32_t var2)    /* + */
        {
            return new uint8_t(var1.var + var2.var);
        }
        public static uint8_t operator -(uint8_t var1, int32_t var2)    /* - */
        {
            return new uint8_t(var1.var - var2.var);
        }
        public static uint8_t operator *(uint8_t var1, int32_t var2)    /* * */
        {
            return new uint8_t(var1.var * var2.var);
        }
        public static uint8_t operator /(uint8_t var1, int32_t var2)    /* / */
        {
            return new uint8_t(var1.var / var2.var);
        }
        public static uint8_t operator %(uint8_t var1, int32_t var2)    /* % */
        {
            return new uint8_t(var1.var & var2.var);
        }
        public static uint8_t operator &(uint8_t var1, int32_t var2)    /* & */
        {
            return new uint8_t(var1.var & var2.var);
        }
        public static uint8_t operator |(uint8_t var1, int32_t var2)    /* | */
        {
            return new uint8_t(var1.var | (uint)var2.var);
        }
        public static uint8_t operator ^(uint8_t var1, int32_t var2)    /* ^ */
        {
            uint8_t result = new uint8_t(var1.var ^ var2.var);
            return result;
        }

        /* Comparison */
        public static bool operator >(uint8_t var1, int32_t var2)       /* > */
        {
            return (var1.var > var2.var) ? true : false;
        }
        public static bool operator <(uint8_t var1, int32_t var2)       /* < */
        {
            return (var1.var < var2.var) ? true : false;
        }
        public static bool operator <=(uint8_t var1, int32_t var2)      /* <= */
        {
            return (var1.var <= var2.var) ? true : false;
        }
        public static bool operator >=(uint8_t var1, int32_t var2)      /* >= */
        {
            return (var1.var >= var2.var) ? true : false;
        }
        public static bool operator ==(uint8_t var1, int32_t var2)      /* == */
        {
            return (var1.var == var2.var) ? true : false;
        }
        public static bool operator !=(uint8_t var1, int32_t var2)      /* != */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region uint32_t
        /* Assignment */
        public static implicit operator uint8_t(uint32_t obj)
        {
            return new uint8_t(obj);
        }

        /* Non-static math operations */
        public uint8_t Add(uint32_t val)                                /* Addition */
        {
            this.var = (byte)(this.var + val.var);
            return this;
        }
        public uint8_t Substract(uint32_t val)                          /* Substraction */
        {
            this.var = (byte)(this.var - val.var);
            return this;
        }
        public uint8_t Multiply(uint32_t val)                           /* Multiplication */
        {
            this.var = (byte)(this.var * val.var);
            return this;
        }
        public uint8_t Divide(uint32_t val)                             /* Division */
        {
            this.var = (byte)(this.var / val.var);
            return this;
        }
        public uint8_t Modulo(uint32_t val)                             /* Modulo */
        {
            this.var = (byte)(this.var % val.var);
            return this;
        }
        public uint8_t AND(uint32_t val)                                /* Bitwise AND operation */
        {
            this.var = (byte)(this.var & val.var);
            return this;
        }
        public uint8_t OR(uint32_t val)                                 /* Bitwise OR operation */
        {
            this.var = (byte)(this.var | (byte)val.var);
            return this;
        }
        public uint8_t XOR(uint32_t val)                                /* Bitwise XOR operation */
        {
            this.var = (byte)(this.var ^ val.var);
            return this;
        }

        /* Math */
        public static uint8_t operator +(uint8_t var1, uint32_t var2)   /* + */
        {
            return new uint8_t(var1.var + var2.var);
        }
        public static uint8_t operator -(uint8_t var1, uint32_t var2)   /* - */
        {
            return new uint8_t(var1.var - var2.var);
        }
        public static uint8_t operator *(uint8_t var1, uint32_t var2)   /* * */
        {
            return new uint8_t(var1.var * var2.var);
        }
        public static uint8_t operator /(uint8_t var1, uint32_t var2)   /* / */
        {
            return new uint8_t(var1.var / var2.var);
        }
        public static uint8_t operator %(uint8_t var1, uint32_t var2)   /* % */
        {
            return new uint8_t(var1.var % var2.var);
        }
        public static uint8_t operator &(uint8_t var1, uint32_t var2)   /* & */
        {
            return new uint8_t(var1.var & var2.var);
        }
        public static uint8_t operator |(uint8_t var1, uint32_t var2)   /* | */
        {
            return new uint8_t(var1.var | var2.var);
        }
        public static uint8_t operator ^(uint8_t var1, uint32_t var2)   /* ^ */
        {
            return new uint8_t(var1.var ^ var2.var);
        }

        /* Comparison */
        public static bool operator >(uint8_t var1, uint32_t var2)      /* > */
        {
            return (var1.var > var2.var) ? true : false;
        }
        public static bool operator <(uint8_t var1, uint32_t var2)      /* < */
        {
            return (var1.var < var2.var) ? true : false;
        }
        public static bool operator <=(uint8_t var1, uint32_t var2)     /* <= */
        {
            return (var1.var <= var2.var) ? true : false;
        }
        public static bool operator >=(uint8_t var1, uint32_t var2)     /* >= */
        {
            return (var1.var >= var2.var) ? true : false;
        }
        public static bool operator ==(uint8_t var1, uint32_t var2)     /* == */
        {
            return (var1.var == var2.var) ? true : false;
        }
        public static bool operator !=(uint8_t var1, uint32_t var2)     /* > */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region int64_t
        /* Assignment */
        public static implicit operator uint8_t(int64_t obj)
        {
            return new uint8_t(obj);
        }

        /* Non-static math operations */
        public uint8_t Add(int64_t val)                                 /* Addition */
        {
            this.var = (byte)(this.var + val.var);
            return this;
        }
        public uint8_t Substract(int64_t val)                           /* Substraction */
        {
            this.var = (byte)(this.var - val.var);
            return this;
        }
        public uint8_t Multiply(int64_t val)                            /* Multiplication */
        {
            this.var = (byte)(this.var * val.var);
            return this;
        }
        public uint8_t Divide(int64_t val)                              /* Division */
        {
            this.var = (byte)(this.var / val.var);
            return this;
        }
        public uint8_t Modulo(int64_t val)                              /* Modulo */
        {
            this.var = (byte)(this.var % val.var);
            return this;
        }
        public uint8_t AND(int64_t val)                                 /* Bitwise AND operation */
        {
            this.var = (byte)(this.var & val.var);
            return this;
        }
        public uint8_t OR(int64_t val)                                  /* Bitwise OR operation */
        {
            this.var = (byte)(this.var | (byte)val.var);
            return this;
        }
        public uint8_t XOR(int64_t val)                                 /* Bitwise XOR operation */
        {
            this.var = (byte)(this.var ^ val.var);
            return this;
        }

        /* Math */
        public static uint8_t operator +(uint8_t var1, int64_t var2)    /* + */
        {
            return new uint8_t(var1.var + var2.var);
        }
        public static uint8_t operator -(uint8_t var1, int64_t var2)    /* - */
        {
            return new uint8_t(var1.var - var2.var);
        }
        public static uint8_t operator *(uint8_t var1, int64_t var2)    /* * */
        {
            return new uint8_t(var1.var * var2.var);
        }
        public static uint8_t operator /(uint8_t var1, int64_t var2)    /* / */
        {
            return new uint8_t(var1.var / var2.var);
        }
        public static uint8_t operator %(uint8_t var1, int64_t var2)    /* % */
        {
            return new uint8_t(var1.var % var2.var);
        }
        public static uint8_t operator &(uint8_t var1, int64_t var2)    /* & */
        {
            return new uint8_t(var1.var & var2.var);
        }
        public static uint8_t operator |(uint8_t var1, int64_t var2)    /* | */
        {
            return new uint8_t(var1.var | (ulong)var2.var);
        }
        public static uint8_t operator ^(uint8_t var1, int64_t var2)    /* ^ */
        {
            return new uint8_t(var1.var ^ var2.var);
        }

        /* Comparison */
        public static bool operator >(uint8_t var1, int64_t var2)       /* > */
        {
            return (var1.var > var2.var) ? true : false;
        }
        public static bool operator <(uint8_t var1, int64_t var2)       /* < */
        {
            return (var1.var < var2.var) ? true : false;
        }
        public static bool operator <=(uint8_t var1, int64_t var2)      /* <= */
        {
            return (var1.var <= var2.var) ? true : false;
        }
        public static bool operator >=(uint8_t var1, int64_t var2)      /* >= */
        {
            return (var1.var >= var2.var) ? true : false;
        }
        public static bool operator ==(uint8_t var1, int64_t var2)      /* == */
        {
            return (var1.var == var2.var) ? true : false;
        }
        public static bool operator !=(uint8_t var1, int64_t var2)      /* != */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region uint64_t
        /* Assignment */
        public static implicit operator uint8_t(uint64_t obj)
        {
            return new uint8_t(obj);
        }

        /* Non-static math operations */
        public uint8_t Add(uint64_t val)                                /* Addition */
        {
            this.var = (byte)(this.var + val.var);
            return this;
        }
        public uint8_t Substract(uint64_t val)                          /* Substraction */
        {
            this.var = (byte)(this.var - val.var);
            return this;
        }
        public uint8_t Multiply(uint64_t val)                           /* Multiplication */
        {
            this.var = (byte)(this.var * val.var);
            return this;
        }
        public uint8_t Divide(uint64_t val)                             /* Division */
        {
            this.var = (byte)(this.var / val.var);
            return this;
        }
        public uint8_t Modulo(uint64_t val)                             /* Modulo */
        {
            this.var = (byte)(this.var % val.var);
            return this;
        }
        public uint8_t AND(uint64_t val)                                /* Bitwise AND operation */
        {
            this.var = (byte)(this.var & val.var);
            return this;
        }
        public uint8_t OR(uint64_t val)                                 /* Bitwise OR operation */
        {
            this.var = (byte)(this.var | (byte)val.var);
            return this;
        }
        public uint8_t XOR(uint64_t val)                                /* Bitwise XOR operation */
        {
            this.var = (byte)(this.var ^ val.var);
            return this;
        }

        /* Math */
        public static uint8_t operator +(uint8_t var1, uint64_t var2)   /* + */
        {
            return new uint8_t(var1.var + var2.var);
        }
        public static uint8_t operator -(uint8_t var1, uint64_t var2)   /* - */
        {
            return new uint8_t(var1.var - var2.var);
        }
        public static uint8_t operator *(uint8_t var1, uint64_t var2)   /* * */
        {
            return new uint8_t(var1.var * var2.var);
        }
        public static uint8_t operator /(uint8_t var1, uint64_t var2)   /* / */
        {
            return new uint8_t(var1.var / var2.var);
        }
        public static uint8_t operator %(uint8_t var1, uint64_t var2)   /* % */
        {
            return new uint8_t(var1.var % var2.var);
        }
        public static uint8_t operator &(uint8_t var1, uint64_t var2)   /* & */
        {
            return new uint8_t(var1.var & var2.var);
        }
        public static uint8_t operator |(uint8_t var1, uint64_t var2)   /* | */
        {
            return new uint8_t(var1.var | var2.var);
        }
        public static uint8_t operator ^(uint8_t var1, uint64_t var2)   /* ^ */
        {
            return new uint8_t(var1.var ^ var2.var);
        }

        /* Comparison */
        public static bool operator >(uint8_t var1, uint64_t var2)      /* > */
        {
            return (var1.var > var2.var) ? true : false;
        }
        public static bool operator <(uint8_t var1, uint64_t var2)      /* < */
        {
            return (var1.var < var2.var) ? true : false;
        }
        public static bool operator <=(uint8_t var1, uint64_t var2)     /* <= */
        {
            return (var1.var <= var2.var) ? true : false;
        }
        public static bool operator >=(uint8_t var1, uint64_t var2)     /* >= */
        {
            return (var1.var >= var2.var) ? true : false;
        }
        public static bool operator ==(uint8_t var1, uint64_t var2)     /* == */
        {
            return (var1.var == var2.var) ? true : false;
        }
        public static bool operator !=(uint8_t var1, uint64_t var2)     /* != */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #endregion

        #region default types
        #region sbyte
        /* Assignment */
        public static implicit operator sbyte(uint8_t obj)
        {
            return (sbyte)obj.var;
        }

        public static implicit operator uint8_t(sbyte var)
        {
            return new uint8_t(var);
        }

        /* Non-static math operations */
        public int8_t Add(sbyte val)                                    /* Addition */
        {
            this.var += (byte)val;
            return this;
        }
        public int8_t Substract(sbyte val)                              /* Substraction */
        {
            this.var -= (byte)val;
            return this;
        }
        public int8_t Multiply(sbyte val)                               /* Multiplication */
        {
            this.var *= (byte)val;
            return this;
        }
        public int8_t Divide(sbyte val)                                 /* Division */
        {
            this.var /= (byte)val;
            return this;
        }
        public int8_t Modulo(sbyte val)                                 /* Modulo */
        {
            this.var %= (byte)val;
            return this;
        }
        public int8_t AND(sbyte val)                                    /* Bitwise AND operation */
        {
            this.var &= (byte)val;
            return this;
        }
        public int8_t OR(sbyte val)                                     /* Bitwise OR operation */
        {
            this.var |= (byte)val;
            return this;
        }
        public int8_t XOR(sbyte val)                                    /* Bitwise XOR operation */
        {
            this.var ^= (byte)val;
            return this;
        }

        /* Math */
        public static uint8_t operator +(uint8_t var1, sbyte var2)      /* + */
        {
            return new uint8_t(var1.var + var2);
        }
        public static uint8_t operator -(uint8_t var1, sbyte var2)      /* - */
        {
            return new uint8_t(var1.var - var2);
        }
        public static uint8_t operator *(uint8_t var1, sbyte var2)      /* * */
        {
            return new uint8_t(var1.var * var2);
        }
        public static uint8_t operator /(uint8_t var1, sbyte var2)      /* / */
        {
            return new uint8_t(var1.var / var2);
        }
        public static uint8_t operator %(uint8_t var1, sbyte var2)      /* % */
        {
            return new uint8_t(var1.var % var2);
        }
        public static uint8_t operator &(uint8_t var1, sbyte var2)      /* & */
        {
            return new uint8_t(var1.var & var2);
        }
        public static uint8_t operator |(uint8_t var1, sbyte var2)      /* | */
        {
            return new uint8_t(var1.var | (byte)var2);
        }
        public static uint8_t operator ^(uint8_t var1, sbyte var2)      /* != */
        {
            return new uint8_t(var1.var ^ var2);
        }

        /* Comparison */
        public static bool operator >(uint8_t var1, sbyte var2)         /* > */
        {
            return (var1.var > var2) ? true : false;
        }
        public static bool operator <(uint8_t var1, sbyte var2)         /* < */
        {
            return (var1.var < var2) ? true : false;
        }
        public static bool operator <=(uint8_t var1, sbyte var2)        /* <= */
        {
            return (var1.var <= var2) ? true : false;
        }
        public static bool operator >=(uint8_t var1, sbyte var2)        /* >= */
        {
            return (var1.var >= var2) ? true : false;
        }
        public static bool operator ==(uint8_t var1, sbyte var2)        /* == */
        {
            return (var1.var == var2) ? true : false;
        }
        public static bool operator !=(uint8_t var1, sbyte var2)        /* != */
        {
            return (var1.var != var2) ? true : false;
        }
        #endregion
        #region byte
        /* Assignment */
        public static implicit operator byte(uint8_t obj)
        {
            return obj.var;
        }

        public static implicit operator uint8_t(byte var)
        {
            return new uint8_t(var);
        }

        /* Non-static math operations */
        public int8_t Add(byte val)                                     /* Addition */
        {                                                               
            this.var += val;                                            
            return this;                                                
        }                                                               
        public int8_t Substract(byte val)                               /* Substraction */
        {                                                               
            this.var -= val;                                            
            return this;                                                
        }                                                               
        public int8_t Multiply(byte val)                                /* Multiplication */
        {                                                               
            this.var *= val;                                            
            return this;                                                
        }                                                               
        public int8_t Divide(byte val)                                  /* Division */
        {                                                               
            this.var /= val;                                            
            return this;                                                
        }                                                               
        public int8_t Modulo(byte val)                                  /* Modulo */
        {                                                               
            this.var %= val;                                            
            return this;                                                
        }                                                               
        public int8_t AND(byte val)                                     /* Bitwise AND operation */
        {                                                               
            this.var &= val;                                            
            return this;                                                
        }                                                               
        public int8_t OR(byte val)                                      /* Bitwise OR operation */
        {                                                               
            this.var |= val;                                            
            return this;                                                
        }                                                               
        public int8_t XOR(byte val)                                     /* Bitwise XOR operation */
        {
            this.var ^= val;
            return this;
        }

        /* Math */
        public static uint8_t operator +(uint8_t var1, byte var2)       /* + */
        {
            return new uint8_t(var1.var + var2);
        }
        public static uint8_t operator -(uint8_t var1, byte var2)       /* - */
        {
            return new uint8_t(var1.var - var2);
        }
        public static uint8_t operator *(uint8_t var1, byte var2)       /* * */
        {
            return new uint8_t(var1.var * var2);
        }
        public static uint8_t operator /(uint8_t var1, byte var2)       /* / */
        {
            return new uint8_t(var1.var / var2);
        }
        public static uint8_t operator %(uint8_t var1, byte var2)       /* % */
        {
            return new uint8_t(var1.var % var2);
        }
        public static uint8_t operator &(uint8_t var1, byte var2)       /* & */
        {
            return new uint8_t(var1.var & var2);
        }
        public static uint8_t operator |(uint8_t var1, byte var2)       /* | */
        {
            return new uint8_t(var1.var | var2);
        }
        public static uint8_t operator ^(uint8_t var1, byte var2)       /* != */
        {
            return new uint8_t(var1.var ^ var2);
        }

        /* Comparison */
        public static bool operator >(uint8_t var1, byte var2)          /* > */
        {
            return (var1.var > var2) ? true : false;
        }
        public static bool operator <(uint8_t var1, byte var2)          /* < */
        {
            return (var1.var < var2) ? true : false;
        }
        public static bool operator <=(uint8_t var1, byte var2)         /* <= */
        {
            return (var1.var <= var2) ? true : false;
        }
        public static bool operator >=(uint8_t var1, byte var2)         /* >= */
        {
            return (var1.var >= var2) ? true : false;
        }
        public static bool operator ==(uint8_t var1, byte var2)         /* == */
        {
            return (var1.var == var2) ? true : false;
        }
        public static bool operator !=(uint8_t var1, byte var2)         /* != */
        {
            return (var1.var != var2) ? true : false;
        }
        #endregion
        #region short
        /* Assignment */
        public static implicit operator short(uint8_t obj)
        {
            return obj.var;
        }

        public static implicit operator uint8_t(short var)
        {
            return new uint8_t(var);
        }

        /* Non-static math operations */
        public int8_t Add(short val)                                    /* Addition */
        {
            this.var += (byte)val;
            return this;
        }
        public int8_t Substract(short val)                              /* Substraction */
        {
            this.var -= (byte)val;
            return this;
        }
        public int8_t Multiply(short val)                               /* Multiplication */
        {
            this.var *= (byte)val;
            return this;
        }
        public int8_t Divide(short val)                                 /* Division */
        {
            this.var /= (byte)val;
            return this;
        }
        public int8_t Modulo(short val)                                 /* Modulo */
        {
            this.var %= (byte)val;
            return this;
        }
        public int8_t AND(short val)                                    /* Bitwise AND operation */
        {
            this.var &= (byte)val;
            return this;
        }
        public int8_t OR(short val)                                     /* Bitwise OR operation */
        {
            this.var |= (byte)val;
            return this;
        }
        public int8_t XOR(short val)                                    /* Bitwise XOR operation */
        {
            this.var ^= (byte)val;
            return this;
        }

        /* Math */
        public static uint8_t operator +(uint8_t var1, short var2)      /* + */
        {
            return new uint8_t(var1.var + var2);
        }
        public static uint8_t operator -(uint8_t var1, short var2)      /* - */
        {
            return new uint8_t(var1.var - var2);
        }
        public static uint8_t operator *(uint8_t var1, short var2)      /* * */
        {
            return new uint8_t(var1.var * var2);
        }
        public static uint8_t operator /(uint8_t var1, short var2)      /* / */
        {
            return new uint8_t(var1.var / var2);
        }
        public static uint8_t operator %(uint8_t var1, short var2)      /* % */
        {
            return new uint8_t(var1.var % var2);
        }
        public static uint8_t operator &(uint8_t var1, short var2)      /* & */
        {
            return new uint8_t(var1.var & var2);
        }
        public static uint8_t operator |(uint8_t var1, short var2)      /* | */
        {
            return new uint8_t(var1.var | (ushort)var2);
        }
        public static uint8_t operator ^(uint8_t var1, short var2)      /* != */
        {
            return new uint8_t(var1.var ^ var2);
        }

        /* Comparison */
        public static bool operator >(uint8_t var1, short var2)         /* > */
        {
            return (var1.var > var2) ? true : false;
        }
        public static bool operator <(uint8_t var1, short var2)         /* < */
        {
            return (var1.var < var2) ? true : false;
        }
        public static bool operator <=(uint8_t var1, short var2)        /* <= */
        {
            return (var1.var <= var2) ? true : false;
        }
        public static bool operator >=(uint8_t var1, short var2)        /* >= */
        {
            return (var1.var >= var2) ? true : false;
        }
        public static bool operator ==(uint8_t var1, short var2)        /* == */
        {
            return (var1.var == var2) ? true : false;
        }
        public static bool operator !=(uint8_t var1, short var2)        /* != */
        {
            return (var1.var != var2) ? true : false;
        }
        #endregion
        #region ushort
        /* Assignment */
        public static implicit operator ushort(uint8_t obj)
        {
            return obj.var;
        }

        public static implicit operator uint8_t(ushort var)
        {
            return new uint8_t(var);
        }

        /* Non-static math operations */
        public int8_t Add(ushort val)                                   /* Addition */
        {
            this.var += (byte)val;
            return this;
        }
        public int8_t Substract(ushort val)                             /* Substraction */
        {
            this.var -= (byte)val;
            return this;
        }
        public int8_t Multiply(ushort val)                              /* Multiplication */
        {
            this.var *= (byte)val;
            return this;
        }
        public int8_t Divide(ushort val)                                /* Division */
        {
            this.var /= (byte)val;
            return this;
        }
        public int8_t Modulo(ushort val)                                /* Modulo */
        {
            this.var %= (byte)val;
            return this;
        }
        public int8_t AND(ushort val)                                   /* Bitwise AND operation */
        {
            this.var &= (byte)val;
            return this;
        }
        public int8_t OR(ushort val)                                    /* Bitwise OR operation */
        {
            this.var |= (byte)val;
            return this;
        }
        public int8_t XOR(ushort val)                                   /* Bitwise XOR operation */
        {
            this.var ^= (byte)val;
            return this;
        }

        /* Math */
        public static uint8_t operator +(uint8_t var1, ushort var2)     /* + */
        {
            return new uint8_t(var1.var + var2);
        }
        public static uint8_t operator -(uint8_t var1, ushort var2)     /* - */
        {
            return new uint8_t(var1.var - var2);
        }
        public static uint8_t operator *(uint8_t var1, ushort var2)     /* * */
        {
            return new uint8_t(var1.var * var2);
        }
        public static uint8_t operator /(uint8_t var1, ushort var2)     /* / */
        {
            return new uint8_t(var1.var / var2);
        }
        public static uint8_t operator %(uint8_t var1, ushort var2)     /* % */
        {
            return new uint8_t(var1.var % var2);
        }
        public static uint8_t operator &(uint8_t var1, ushort var2)     /* & */
        {
            return new uint8_t(var1.var & var2);
        }
        public static uint8_t operator |(uint8_t var1, ushort var2)     /* | */
        {
            return new uint8_t(var1.var | var2);
        }
        public static uint8_t operator ^(uint8_t var1, ushort var2)     /* != */
        {
            return new uint8_t(var1.var ^ var2);
        }

        /* Comparison */
        public static bool operator >(uint8_t var1, ushort var2)        /* > */
        {
            return (var1.var > var2) ? true : false;
        }
        public static bool operator <(uint8_t var1, ushort var2)        /* < */
        {
            return (var1.var < var2) ? true : false;
        }
        public static bool operator <=(uint8_t var1, ushort var2)       /* <= */
        {
            return (var1.var <= var2) ? true : false;
        }
        public static bool operator >=(uint8_t var1, ushort var2)       /* >= */
        {
            return (var1.var >= var2) ? true : false;
        }
        public static bool operator ==(uint8_t var1, ushort var2)       /* == */
        {
            return (var1.var == var2) ? true : false;
        }
        public static bool operator !=(uint8_t var1, ushort var2)       /* != */
        {
            return (var1.var != var2) ? true : false;
        }
        #endregion
        #region int
        /* Assignment */
        public static implicit operator int(uint8_t obj)
        {
            return obj.var;
        }

        public static implicit operator uint8_t(int var)
        {
            return new uint8_t(var);
        }

        /* Non-static math operations */
        public int8_t Add(int val)                                      /* Addition */
        {                                                               
            this.var += (byte)val;                                      
            return this;                                                
        }                                                               
        public int8_t Substract(int val)                                /* Substraction */
        {                                                               
            this.var -= (byte)val;                                      
            return this;                                                
        }                                                               
        public int8_t Multiply(int val)                                 /* Multiplication */
        {                                                               
            this.var *= (byte)val;                                      
            return this;                                                
        }                                                               
        public int8_t Divide(int val)                                   /* Division */
        {                                                               
            this.var /= (byte)val;                                      
            return this;                                                
        }                                                               
        public int8_t Modulo(int val)                                   /* Modulo */
        {                                                               
            this.var %= (byte)val;                                      
            return this;                                                
        }                                                               
        public int8_t AND(int val)                                      /* Bitwise AND operation */
        {                                                               
            this.var &= (byte)val;                                      
            return this;                                                
        }                                                               
        public int8_t OR(int val)                                       /* Bitwise OR operation */
        {                                                               
            this.var |= (byte)val;                                      
            return this;                                                
        }                                                               
        public int8_t XOR(int val)                                      /* Bitwise XOR operation */
        {
            this.var ^= (byte)val;
            return this;
        }

        /* Math */
        public static uint8_t operator +(uint8_t var1, int var2)        /* + */
        {
            return new uint8_t(var1.var + var2);
        }
        public static uint8_t operator -(uint8_t var1, int var2)        /* - */
        {
            return new uint8_t(var1.var - var2);
        }
        public static uint8_t operator *(uint8_t var1, int var2)        /* * */
        {
            return new uint8_t(var1.var * var2);
        }
        public static uint8_t operator /(uint8_t var1, int var2)        /* / */
        {
            return new uint8_t(var1.var / var2);
        }
        public static uint8_t operator %(uint8_t var1, int var2)        /* % */
        {
            return new uint8_t(var1.var % var2);
        }
        public static uint8_t operator &(uint8_t var1, int var2)        /* & */
        {
            return new uint8_t(var1.var & var2);
        }
        public static uint8_t operator |(uint8_t var1, int var2)        /* | */
        {
            return new uint8_t(var1.var | (uint)var2);
        }
        public static uint8_t operator ^(uint8_t var1, int var2)        /* ^ */
        {
            return new uint8_t(var1.var ^ var2);
        }
        public static uint8_t operator >>(uint8_t var1, int var2)       /* >> */
        {
            return new uint8_t(var1.var >> var2);
        }
        public static uint8_t operator <<(uint8_t var1, int var2)       /* << */
        {
            return new uint8_t(var1.var << var2);
        }

        /* Comparison */
        public static bool operator >(uint8_t var1, int var2)           /* > */
        {
            return (var1.var > var2) ? true : false;
        }
        public static bool operator <(uint8_t var1, int var2)           /* < */
        {
            return (var1.var < var2) ? true : false;
        }
        public static bool operator <=(uint8_t var1, int var2)          /* <= */
        {
            return (var1.var <= var2) ? true : false;
        }
        public static bool operator >=(uint8_t var1, int var2)          /* >= */
        {
            return (var1.var >= var2) ? true : false;
        }
        public static bool operator ==(uint8_t var1, int var2)          /* == */
        {
            return (var1.var == var2) ? true : false;
        }
        public static bool operator !=(uint8_t var1, int var2)          /* != */
        {
            return (var1.var != var2) ? true : false;
        }
        #endregion
        #region uint
        /* Assignment */
        public static implicit operator uint(uint8_t obj)
        {
            return obj.var;
        }

        public static implicit operator uint8_t(uint var)
        {
            return new uint8_t(var);
        }

        /* Non-static math operations */
        public int8_t Add(uint val)                                     /* Addition */
        {                                                               
            this.var += (byte)val;                                      
            return this;                                                
        }                                                               
        public int8_t Substract(uint val)                               /* Substraction */
        {                                                               
            this.var -= (byte)val;                                      
            return this;                                                
        }                                                               
        public int8_t Multiply(uint val)                                /* Multiplication */
        {                                                               
            this.var *= (byte)val;                                      
            return this;                                                
        }                                                               
        public int8_t Divide(uint val)                                  /* Division */
        {                                                               
            this.var /= (byte)val;                                      
            return this;                                                
        }                                                               
        public int8_t Modulo(uint val)                                  /* Modulo */
        {                                                               
            this.var %= (byte)val;                                      
            return this;                                                
        }                                                               
        public int8_t AND(uint val)                                     /* Bitwise AND operation */
        {                                                               
            this.var &= (byte)val;                                      
            return this;                                                
        }                                                               
        public int8_t OR(uint val)                                      /* Bitwise OR operation */
        {                                                               
            this.var |= (byte)val;                                      
            return this;                                                
        }                                                               
        public int8_t XOR(uint val)                                     /* Bitwise XOR operation */
        {
            this.var ^= (byte)val;
            return this;
        }

        /* Math */
        public static uint8_t operator +(uint8_t var1, uint var2)       /* + */
        {
            return new uint8_t(var1.var + var2);
        }
        public static uint8_t operator -(uint8_t var1, uint var2)       /* - */
        {
            return new uint8_t(var1.var - var2);
        }
        public static uint8_t operator *(uint8_t var1, uint var2)       /* * */
        {
            return new uint8_t(var1.var * var2);
        }
        public static uint8_t operator /(uint8_t var1, uint var2)       /* / */
        {
            return new uint8_t(var1.var / var2);
        }
        public static uint8_t operator %(uint8_t var1, uint var2)       /* % */
        {
            return new uint8_t(var1.var % var2);
        }
        public static uint8_t operator &(uint8_t var1, uint var2)       /* & */
        {
            return new uint8_t(var1.var & var2);
        }
        public static uint8_t operator |(uint8_t var1, uint var2)       /* | */
        {
            return new uint8_t(var1.var | var2);
        }
        public static uint8_t operator ^(uint8_t var1, uint var2)       /* != */
        {
            return new uint8_t(var1.var ^ var2);
        }

        /* Comparison */
        public static bool operator >(uint8_t var1, uint var2)          /* > */
        {
            return (var1.var > var2) ? true : false;
        }
        public static bool operator <(uint8_t var1, uint var2)          /* < */
        {
            return (var1.var < var2) ? true : false;
        }
        public static bool operator <=(uint8_t var1, uint var2)         /* <= */
        {
            return (var1.var <= var2) ? true : false;
        }
        public static bool operator >=(uint8_t var1, uint var2)         /* >= */
        {
            return (var1.var >= var2) ? true : false;
        }
        public static bool operator ==(uint8_t var1, uint var2)         /* == */
        {
            return (var1.var == var2) ? true : false;
        }
        public static bool operator !=(uint8_t var1, uint var2)         /* != */
        {
            return (var1.var != var2) ? true : false;
        }
        #endregion
        #region long
        /* Assignment */
        public static implicit operator long(uint8_t obj)
        {
            return obj.var;
        }

        public static implicit operator uint8_t(long var)
        {
            return new uint8_t(var);
        }

        /* Non-static math operations */
        public int8_t Add(long val)                                     /* Addition */
        {                                                               
            this.var += (byte)val;                                      
            return this;                                                
        }                                                               
        public int8_t Substract(long val)                               /* Substraction */
        {                                                               
            this.var -= (byte)val;                                      
            return this;                                                
        }                                                               
        public int8_t Multiply(long val)                                /* Multiplication */
        {                                                               
            this.var *= (byte)val;                                      
            return this;                                                
        }                                                               
        public int8_t Divide(long val)                                  /* Division */
        {                                                               
            this.var /= (byte)val;                                      
            return this;                                                
        }                                                               
        public int8_t Modulo(long val)                                  /* Modulo */
        {                                                               
            this.var %= (byte)val;                                      
            return this;                                                
        }                                                               
        public int8_t AND(long val)                                     /* Bitwise AND operation */
        {                                                               
            this.var &= (byte)val;                                      
            return this;                                                
        }                                                               
        public int8_t OR(long val)                                      /* Bitwise OR operation */
        {                                                               
            this.var |= (byte)val;                                      
            return this;                                                
        }                                                               
        public int8_t XOR(long val)                                     /* Bitwise XOR operation */
        {
            this.var ^= (byte)val;
            return this;
        }

        /* Math */
        public static uint8_t operator +(uint8_t var1, long var2)       /* + */
        {
            return new uint8_t(var1.var + var2);
        }
        public static uint8_t operator -(uint8_t var1, long var2)       /* - */
        {
            return new uint8_t(var1.var - var2);
        }
        public static uint8_t operator *(uint8_t var1, long var2)       /* * */
        {
            return new uint8_t(var1.var * var2);
        }
        public static uint8_t operator /(uint8_t var1, long var2)       /* / */
        {
            return new uint8_t(var1.var / var2);
        }
        public static uint8_t operator %(uint8_t var1, long var2)       /* % */
        {
            return new uint8_t(var1.var % var2);
        }
        public static uint8_t operator &(uint8_t var1, long var2)       /* & */
        {
            return new uint8_t(var1.var & var2);
        }
        public static uint8_t operator |(uint8_t var1, long var2)       /* | */
        {
            return new uint8_t(var1.var | var2);
        }
        public static uint8_t operator ^(uint8_t var1, long var2)       /* != */
        {
            return new uint8_t(var1.var ^ var2);
        }

        /* Comparison */
        public static bool operator >(uint8_t var1, long var2)          /* > */
        {
            return (var1.var > var2) ? true : false;
        }
        public static bool operator <(uint8_t var1, long var2)          /* < */
        {
            return (var1.var < var2) ? true : false;
        }
        public static bool operator <=(uint8_t var1, long var2)         /* <= */
        {
            return (var1.var <= var2) ? true : false;
        }
        public static bool operator >=(uint8_t var1, long var2)         /* >= */
        {
            return (var1.var >= var2) ? true : false;
        }
        public static bool operator ==(uint8_t var1, long var2)         /* == */
        {
            return (var1.var == var2) ? true : false;
        }
        public static bool operator !=(uint8_t var1, long var2)         /* != */
        {
            return (var1.var != var2) ? true : false;
        }
        #endregion
        #region ulong
        /* Assignment */
        public static implicit operator ulong(uint8_t obj)
        {
            return obj.var;
        }

        public static implicit operator uint8_t(ulong var)
        {
            return new uint8_t(var);
        }

        /* Non-static math operations */
        public int8_t Add(ulong val)                                    /* Addition */
        {
            this.var += (byte)val;
            return this;
        }
        public int8_t Substract(ulong val)                              /* Substraction */
        {
            this.var -= (byte)val;
            return this;
        }
        public int8_t Multiply(ulong val)                               /* Multiplication */
        {
            this.var *= (byte)val;
            return this;
        }
        public int8_t Divide(ulong val)                                 /* Division */
        {
            this.var /= (byte)val;
            return this;
        }
        public int8_t Modulo(ulong val)                                 /* Modulo */
        {
            this.var %= (byte)val;
            return this;
        }
        public int8_t AND(ulong val)                                    /* Bitwise AND operation */
        {
            this.var &= (byte)val;
            return this;
        }
        public int8_t OR(ulong val)                                     /* Bitwise OR operation */
        {
            this.var |= (byte)val;
            return this;
        }
        public int8_t XOR(ulong val)                                    /* Bitwise XOR operation */
        {
            this.var ^= (byte)val;
            return this;
        }

        /* Math */
        public static uint8_t operator +(uint8_t var1, ulong var2)      /* + */
        {
            return new uint8_t(var1.var + var2);
        }
        public static uint8_t operator -(uint8_t var1, ulong var2)      /* - */
        {
            return new uint8_t(var1.var - var2);
        }
        public static uint8_t operator *(uint8_t var1, ulong var2)      /* * */
        {
            return new uint8_t(var1.var * var2);
        }
        public static uint8_t operator /(uint8_t var1, ulong var2)      /* / */
        {
            return new uint8_t(var1.var / var2);
        }
        public static uint8_t operator %(uint8_t var1, ulong var2)      /* % */
        {
            return new uint8_t(var1.var % var2);
        }
        public static uint8_t operator &(uint8_t var1, ulong var2)      /* & */
        {
            return new uint8_t(var1.var & var2);
        }
        public static uint8_t operator |(uint8_t var1, ulong var2)      /* | */
        {
            return new uint8_t(var1.var | var2);
        }
        public static uint8_t operator ^(uint8_t var1, ulong var2)      /* != */
        {
            return new uint8_t(var1.var ^ var2);
        }

        /* Comparison */
        public static bool operator >(uint8_t var1, ulong var2)         /* > */
        {
            return (var1.var > var2) ? true : false;
        }
        public static bool operator <(uint8_t var1, ulong var2)         /* < */
        {
            return (var1.var < var2) ? true : false;
        }
        public static bool operator <=(uint8_t var1, ulong var2)        /* <= */
        {
            return (var1.var <= var2) ? true : false;
        }
        public static bool operator >=(uint8_t var1, ulong var2)        /* >= */
        {
            return (var1.var >= var2) ? true : false;
        }
        public static bool operator ==(uint8_t var1, ulong var2)        /* == */
        {
            return (var1.var == var2) ? true : false;
        }
        public static bool operator !=(uint8_t var1, ulong var2)        /* != */
        {
            return (var1.var != var2) ? true : false;
        }
        #endregion

        #region float
        /* Non-static math operations */
        public int8_t Add(float val)                                    /* Addition */
        {
            this.var += System.Convert.ToByte(System.Math.Truncate(val));
            return this;
        }
        public int8_t Substract(float val)                              /* Substraction */
        {
            this.var -= System.Convert.ToByte(System.Math.Truncate(val)); ;
            return this;
        }
        public int8_t Multiply(float val)                               /* Multiplication */
        {
            this.var *= System.Convert.ToByte(System.Math.Truncate(val)); ;
            return this;
        }
        public int8_t Divide(float val)                                 /* Division */
        {
            this.var /= System.Convert.ToByte(System.Math.Truncate(val)); ;
            return this;
        }
        public int8_t Modulo(float val)                                 /* Modulo */
        {
            this.var %= System.Convert.ToByte(System.Math.Truncate(val)); ;
            return this;
        }
        public int8_t AND(float val)                                    /* Bitwise AND operation */
        {
            throw new System.ArgumentException(System.String.Format("& operator cannot be applied with float parameter {0}", val));
        }
        public int8_t OR(float val)                                     /* Bitwise OR operation */
        {
            throw new System.ArgumentException(System.String.Format("| operator cannot be applied with float parameter {0}", val));
        }
        public int8_t XOR(float val)                                    /* Bitwise XOR operation */
        {
            throw new System.ArgumentException(System.String.Format("^ operator cannot be applied with float parameter {0}", val));
        }

        /* Math */
        public static uint8_t operator +(uint8_t var1, float var2)      /* + */
        {
            return new uint8_t(var1.var + var2);
        }
        public static uint8_t operator -(uint8_t var1, float var2)      /* - */
        {
            return new uint8_t(var1.var - var2);
        }
        public static uint8_t operator *(uint8_t var1, float var2)      /* * */
        {
            return new uint8_t(var1.var * var2);
        }
        public static uint8_t operator /(uint8_t var1, float var2)      /* / */
        {
            return new uint8_t(var1.var / var2);
        }
        public static uint8_t operator %(uint8_t var1, float var2)      /* % */
        {
            return new uint8_t(var1.var % var2);
        }
        public static uint8_t operator &(uint8_t var1, float var2)      /* & */
        {
            throw new System.ArgumentException(System.String.Format("& operator cannot be applied with float parameter {0}", var2));
        }
        public static uint8_t operator |(uint8_t var1, float var2)      /* | */
        {
            throw new System.ArgumentException(System.String.Format("| operator cannot be applied with float parameter {0}", var2));
        }
        public static uint8_t operator ^(uint8_t var1, float var2)      /* != */
        {
            throw new System.ArgumentException(System.String.Format("^ operator cannot be applied with float parameter {0}", var2));
        }

        /* Comparison */
        public static bool operator >(uint8_t var1, float var2)         /* > */
        {
            return (var1.var > var2) ? true : false;
        }
        public static bool operator <(uint8_t var1, float var2)         /* < */
        {
            return (var1.var < var2) ? true : false;
        }
        public static bool operator <=(uint8_t var1, float var2)        /* <= */
        {
            return (var1.var <= var2) ? true : false;
        }
        public static bool operator >=(uint8_t var1, float var2)        /* >= */
        {
            return (var1.var >= var2) ? true : false;
        }
        public static bool operator ==(uint8_t var1, float var2)        /* == */
        {
            return (var1.var == var2) ? true : false;
        }
        public static bool operator !=(uint8_t var1, float var2)        /* != */
        {
            return (var1.var != var2) ? true : false;
        }
        #endregion
        #region double
        /* Non-static math operations */
        public int8_t Add(double val)                                   /* Addition */
        {
            this.var += System.Convert.ToByte(System.Math.Truncate(val));
            return this;
        }
        public int8_t Substract(double val)                             /* Substraction */
        {
            this.var -= System.Convert.ToByte(System.Math.Truncate(val)); ;
            return this;
        }
        public int8_t Multiply(double val)                              /* Multiplication */
        {
            this.var *= System.Convert.ToByte(System.Math.Truncate(val)); ;
            return this;
        }
        public int8_t Divide(double val)                                /* Division */
        {
            this.var /= System.Convert.ToByte(System.Math.Truncate(val)); ;
            return this;
        }
        public int8_t Modulo(double val)                                /* Modulo */
        {
            this.var %= System.Convert.ToByte(System.Math.Truncate(val)); ;
            return this;
        }
        public int8_t AND(double val)                                   /* Bitwise AND operation */
        {
            throw new System.ArgumentException(System.String.Format("& operator cannot be applied with double parameter {0}", val));
        }
        public int8_t OR(double val)                                    /* Bitwise OR operation */
        {
            throw new System.ArgumentException(System.String.Format("| operator cannot be applied with double parameter {0}", val));
        }
        public int8_t XOR(double val)                                   /* Bitwise XOR operation */
        {
            throw new System.ArgumentException(System.String.Format("^ operator cannot be applied with double parameter {0}", val));
        }

        /* Math */
        public static uint8_t operator +(uint8_t var1, double var2)     /* + */
        {
            return new uint8_t(var1.var + var2);
        }
        public static uint8_t operator -(uint8_t var1, double var2)     /* - */
        {
            return new uint8_t(var1.var - var2);
        }
        public static uint8_t operator *(uint8_t var1, double var2)     /* * */
        {
            return new uint8_t(var1.var * var2);
        }
        public static uint8_t operator /(uint8_t var1, double var2)     /* / */
        {
            return new uint8_t(var1.var / var2);
        }
        public static uint8_t operator %(uint8_t var1, double var2)     /* % */
        {
            return new uint8_t(var1.var % var2);
        }
        public static uint8_t operator &(uint8_t var1, double var2)     /* & */
        {
            throw new System.ArgumentException(System.String.Format("& operator cannot be applied with double parameter {0}", var2));
        }
        public static uint8_t operator |(uint8_t var1, double var2)     /* | */
        {
            throw new System.ArgumentException(System.String.Format("| operator cannot be applied with double parameter {0}", var2));
        }
        public static uint8_t operator ^(uint8_t var1, double var2)     /* != */
        {
            throw new System.ArgumentException(System.String.Format("^ operator cannot be applied with double parameter {0}", var2));
        }

        /* Comparison */
        public static bool operator >(uint8_t var1, double var2)        /* > */
        {
            return (var1.var > var2) ? true : false;
        }
        public static bool operator <(uint8_t var1, double var2)        /* < */
        {
            return (var1.var < var2) ? true : false;
        }
        public static bool operator <=(uint8_t var1, double var2)       /* <= */
        {
            return (var1.var <= var2) ? true : false;
        }
        public static bool operator >=(uint8_t var1, double var2)       /* >= */
        {
            return (var1.var >= var2) ? true : false;
        }
        public static bool operator ==(uint8_t var1, double var2)       /* == */
        {
            return (var1.var == var2) ? true : false;
        }
        public static bool operator !=(uint8_t var1, double var2)       /* != */
        {
            return (var1.var != var2) ? true : false;
        }
        #endregion
        #endregion
        #endregion

        #region specials
        public override bool Equals(object obj)
        {
            return (obj is uint8_t) ? this == (uint8_t)obj : false;
        }
        public override int GetHashCode()
        {
            return var;
        }
        public override string ToString()
        {
            return var.ToString();
        }

        public uint8_t Increment()
        {
            this.var++;
            return this;
        }
        public uint8_t Decrement()
        {
            this.var--;
            return this;
        }
        #endregion
    }

    /****************************** int16_t **********************************/
    class int16_t
    {
        public short var = 0;

        #region Constructors
        public int16_t()                { var = 0; }
        public int16_t(byte value)      { var = (short)value; }
        public int16_t(sbyte value)     { var = (short)value; }
        public int16_t(short value)     { var = value; }
        public int16_t(ushort value)    { var = (short)value; }
        public int16_t(int value)       { var = (short)value; }
        public int16_t(uint value)      { var = (short)value; }
        public int16_t(long value)      { var = (short)value; }
        public int16_t(ulong value)     { var = (short)value; }
        public int16_t(float value)     { var = System.Convert.ToInt16(System.Math.Truncate(value)); }
        public int16_t(double value)    { var = System.Convert.ToInt16(System.Math.Truncate(value)); }
        public int16_t(int8_t value)    { var = (short)value.var; }
        public int16_t(uint8_t value)   { var = (short)value.var; }
        public int16_t(int16_t value)   { var = value.var; }
        public int16_t(uint16_t value)  { var = (short)value.var; }
        public int16_t(int32_t value)   { var = (short)value.var; }
        public int16_t(uint32_t value)  { var = (short)value.var; }
        public int16_t(int64_t value)   { var = (short)value.var; }
        public int16_t(uint64_t value)  { var = (short)value.var; }
        #endregion


        #region types
        #region new types
        #region int8_t
        /* Assignment */
        public static implicit operator int16_t(int8_t obj)
        {
            return new int16_t(obj);
        }

        /* Math */
        public static int16_t operator +(int16_t var1, int8_t var2)     /* + */
        {
            return new int16_t(var1.var + var2.var);
        }
        public static int16_t operator -(int16_t var1, int8_t var2)     /* - */
        {
            return new int16_t(var1.var - var2.var);
        }
        public static int16_t operator *(int16_t var1, int8_t var2)     /* * */
        {
            return new int16_t(var1.var * var2.var);
        }
        public static int16_t operator /(int16_t var1, int8_t var2)     /* / */
        {
            return new int16_t(var1.var / var2.var);
        }
        public static int16_t operator %(int16_t var1, int8_t var2)     /* % */
        {
            return new int16_t(var1.var % var2.var);
        }
        public static int16_t operator &(int16_t var1, int8_t var2)     /* & */
        {
            return new int16_t(var1.var & var2.var);
        }
        public static int16_t operator |(int16_t var1, int8_t var2)     /* | */
        {
            return new int16_t((ushort)var1.var | (byte)var2.var);
        }
        public static int16_t operator ^(int16_t var1, int8_t var2)     /* ^ */
        {
            return new int16_t(var1.var ^ var2.var);
        }

        /* Comparison */
        public static bool operator >(int16_t var1, int8_t var2)        /* > */
        {
            return (var1.var > var2.var) ? true : false;
        }
        public static bool operator <(int16_t var1, int8_t var2)        /* < */
        {
            return (var1.var < var2.var) ? true : false;
        }
        public static bool operator <=(int16_t var1, int8_t var2)       /* <= */
        {
            return (var1.var <= var2.var) ? true : false;
        }
        public static bool operator >=(int16_t var1, int8_t var2)       /* >= */
        {
            return (var1.var >= var2.var) ? true : false;
        }
        public static bool operator ==(int16_t var1, int8_t var2)       /* == */
        {
            return (var1.var == var2.var) ? true : false;
        }
        public static bool operator !=(int16_t var1, int8_t var2)       /* != */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region uint8_t
        /* Assignment */
        public static implicit operator int16_t(uint8_t obj)
        {
            return new int16_t(obj);
        }

        /* Math */
        public static int16_t operator +(int16_t var1, uint8_t var2)    /* + */
        {
            return new int16_t(var1.var + var2.var);
        }
        public static int16_t operator -(int16_t var1, uint8_t var2)    /* - */
        {
            return new int16_t(var1.var - var2.var);
        }
        public static int16_t operator *(int16_t var1, uint8_t var2)    /* * */
        {
            return new int16_t(var1.var * var2.var);
        }
        public static int16_t operator /(int16_t var1, uint8_t var2)    /* / */
        {
            return new int16_t(var1.var / var2.var);
        }
        public static int16_t operator %(int16_t var1, uint8_t var2)    /* % */
        {
            return new int16_t(var1.var % var2.var);
        }
        public static int16_t operator &(int16_t var1, uint8_t var2)    /* & */
        {
            return new int16_t(var1.var & var2.var);
        }
        public static int16_t operator |(int16_t var1, uint8_t var2)    /* | */
        {
            return new int16_t((ushort)var1.var | var2.var);
        }
        public static int16_t operator ^(int16_t var1, uint8_t var2)    /* ^ */
        {
            return new int16_t(var1.var ^ var2.var);
        }

        /* Comparison */
        public static bool operator >(int16_t var1, uint8_t var2)       /* > */
        {
            return (var1.var > var2.var) ? true : false;
        }
        public static bool operator <(int16_t var1, uint8_t var2)       /* < */
        {
            return (var1.var < var2.var) ? true : false;
        }
        public static bool operator <=(int16_t var1, uint8_t var2)      /* <= */
        {
            return (var1.var <= var2.var) ? true : false;
        }
        public static bool operator >=(int16_t var1, uint8_t var2)      /* >= */
        {
            return (var1.var >= var2.var) ? true : false;
        }
        public static bool operator ==(int16_t var1, uint8_t var2)      /* == */
        {
            return (var1.var == var2.var) ? true : false;
        }
        public static bool operator !=(int16_t var1, uint8_t var2)      /* != */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region int16_t
        /* Unary operators */
        public static int16_t operator ++(int16_t obj)                  /* ++ */
        {
            obj.Increment();
            return obj;
        }
        public static int16_t operator --(int16_t obj)                  /* -- */
        {
            obj.Decrement();
            return obj;
        }
        public static int16_t operator -(int16_t obj)                   /* - (unary) */
        {
            return new int16_t(-obj.var);
        }
        public static int16_t operator +(int16_t obj)                   /* + (unary) */
        {
            return new int16_t(obj);
        }
        public static int16_t operator ~(int16_t obj)                   /* ~ */
        {
            return new int16_t(~obj.var);
        }

        /* Math */
        public static int16_t operator +(int16_t var1, int16_t var2)    /* + */
        {
            return new int16_t(var1.var + var2.var);
        }
        public static int16_t operator -(int16_t var1, int16_t var2)    /* - */
        {
            return new int16_t(var1.var - var2.var);
        }
        public static int16_t operator *(int16_t var1, int16_t var2)    /* * */
        {
            return new int16_t(var1.var * var2.var);
        }
        public static int16_t operator /(int16_t var1, int16_t var2)    /* / */
        {
            return new int16_t(var1.var / var2.var);
        }
        public static int16_t operator %(int16_t var1, int16_t var2)    /* % */
        {
            return new int16_t(var1.var % var2.var);
        }
        public static int16_t operator &(int16_t var1, int16_t var2)    /* & */
        {
            return new int16_t(var1.var & var2.var);
        }
        public static int16_t operator |(int16_t var1, int16_t var2)    /* | */
        {
            return new int16_t(var1.var | var2.var);
        }
        public static int16_t operator ^(int16_t var1, int16_t var2)    /* ^ */
        {
            return new int16_t(var1.var ^ var2.var);
        }

        /* Comparison */
        public static bool operator >(int16_t var1, int16_t var2)       /* > */
        {
            return (var1.var > var2.var) ? true : false;
        }
        public static bool operator <(int16_t var1, int16_t var2)       /* < */
        {
            return (var1.var < var2.var) ? true : false;
        }
        public static bool operator <=(int16_t var1, int16_t var2)      /* <= */
        {
            return (var1.var <= var2.var) ? true : false;
        }
        public static bool operator >=(int16_t var1, int16_t var2)      /* >= */
        {
            return (var1.var >= var2.var) ? true : false;
        }
        public static bool operator ==(int16_t var1, int16_t var2)      /* == */
        {
            return (var1.var == var2.var) ? true : false;
        }
        public static bool operator !=(int16_t var1, int16_t var2)      /* != */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region uint16_t
        /* Assignment */
        public static implicit operator int16_t(uint16_t obj)
        {
            return new int16_t(obj);
        }

        /* Math */
        public static int16_t operator +(int16_t var1, uint16_t var2)   /* + */
        {
            return new int16_t(var1.var + var2.var);
        }
        public static int16_t operator -(int16_t var1, uint16_t var2)   /* - */
        {
            return new int16_t(var1.var - var2.var);
        }
        public static int16_t operator *(int16_t var1, uint16_t var2)   /* * */
        {
            return new int16_t(var1.var * var2.var);
        }
        public static int16_t operator /(int16_t var1, uint16_t var2)   /* / */
        {
            return new int16_t(var1.var / var2.var);
        }
        public static int16_t operator %(int16_t var1, uint16_t var2)   /* % */
        {
            return new int16_t(var1.var % var2.var);
        }
        public static int16_t operator &(int16_t var1, uint16_t var2)   /* & */
        {
            return new int16_t(var1.var & var2.var);
        }
        public static int16_t operator |(int16_t var1, uint16_t var2)   /* | */
        {
            return new int16_t((ushort)var1.var | var2.var);
        }
        public static int16_t operator ^(int16_t var1, uint16_t var2)   /* ^ */
        {
            return new int16_t(var1.var ^ var2.var);
        }

        /* Comparison */
        public static bool operator >(int16_t var1, uint16_t var2)      /* > */
        {
            return (var1.var > var2.var) ? true : false;
        }
        public static bool operator <(int16_t var1, uint16_t var2)      /* < */
        {
            return (var1.var < var2.var) ? true : false;
        }
        public static bool operator <=(int16_t var1, uint16_t var2)     /* <= */
        {
            return (var1.var <= var2.var) ? true : false;
        }
        public static bool operator >=(int16_t var1, uint16_t var2)     /* >= */
        {
            return (var1.var >= var2.var) ? true : false;
        }
        public static bool operator ==(int16_t var1, uint16_t var2)     /* == */
        {
            return (var1.var == var2.var) ? true : false;
        }
        public static bool operator !=(int16_t var1, uint16_t var2)     /* != */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region int32_t
        /* Assignment */
        public static implicit operator int16_t(int32_t obj)
        {
            return new int16_t(obj);
        }

        /* Math */
        public static int16_t operator +(int16_t var1, int32_t var2)    /* + */
        {
            return new int16_t(var1.var + var2.var);
        }
        public static int16_t operator -(int16_t var1, int32_t var2)    /* - */
        {
            return new int16_t(var1.var - var2.var);
        }
        public static int16_t operator *(int16_t var1, int32_t var2)    /* * */
        {
            return new int16_t(var1.var * var2.var);
        }
        public static int16_t operator /(int16_t var1, int32_t var2)    /* / */
        {
            return new int16_t(var1.var / var2.var);
        }
        public static int16_t operator %(int16_t var1, int32_t var2)    /* % */
        {
            return new int16_t(var1.var % var2.var);
        }
        public static int16_t operator &(int16_t var1, int32_t var2)    /* & */
        {
            return new int16_t(var1.var & var2.var);
        }
        public static int16_t operator |(int16_t var1, int32_t var2)    /* | */
        {
            return new int16_t((ushort)var1.var | var2.var);
        }
        public static int16_t operator ^(int16_t var1, int32_t var2)    /* ^ */
        {
            return new int16_t(var1.var ^ var2.var);
        }

        /* Comparison */
        public static bool operator >(int16_t var1, int32_t var2)       /* > */
        {
            return (var1.var > var2.var) ? true : false;
        }
        public static bool operator <(int16_t var1, int32_t var2)       /* < */
        {
            return (var1.var < var2.var) ? true : false;
        }
        public static bool operator <=(int16_t var1, int32_t var2)      /* <= */
        {
            return (var1.var <= var2.var) ? true : false;
        }
        public static bool operator >=(int16_t var1, int32_t var2)      /* >= */
        {
            return (var1.var >= var2.var) ? true : false;
        }
        public static bool operator ==(int16_t var1, int32_t var2)      /* == */
        {
            return (var1.var == var2.var) ? true : false;
        }
        public static bool operator !=(int16_t var1, int32_t var2)      /* != */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region uint32_t
        /* Assignment */
        public static implicit operator int16_t(uint32_t obj)
        {
            return new int16_t(obj);
        }

        /* Math */
        public static int16_t operator +(int16_t var1, uint32_t var2)   /* + */
        {
            return new int16_t(var1.var + var2.var);
        }
        public static int16_t operator -(int16_t var1, uint32_t var2)   /* - */
        {
            return new int16_t(var1.var - var2.var);
        }
        public static int16_t operator *(int16_t var1, uint32_t var2)   /* * */
        {
            return new int16_t(var1.var * var2.var);
        }
        public static int16_t operator /(int16_t var1, uint32_t var2)   /* / */
        {
            return new int16_t(var1.var / var2.var);
        }
        public static int16_t operator %(int16_t var1, uint32_t var2)   /* % */
        {
            return new int16_t(var1.var % var2.var);
        }
        public static int16_t operator &(int16_t var1, uint32_t var2)   /* & */
        {
            return new int16_t(var1.var & var2.var);
        }
        public static int16_t operator |(int16_t var1, uint32_t var2)   /* | */
        {
            return new int16_t((ushort)var1.var | var2.var);
        }
        public static int16_t operator ^(int16_t var1, uint32_t var2)   /* ^ */
        {
            return new int16_t(var1.var ^ var2.var);
        }

        /* Comparison */
        public static bool operator >(int16_t var1, uint32_t var2)      /* > */
        {
            return (var1.var > var2.var) ? true : false;
        }
        public static bool operator <(int16_t var1, uint32_t var2)      /* < */
        {
            return (var1.var < var2.var) ? true : false;
        }
        public static bool operator <=(int16_t var1, uint32_t var2)     /* <= */
        {
            return (var1.var <= var2.var) ? true : false;
        }
        public static bool operator >=(int16_t var1, uint32_t var2)     /* >= */
        {
            return (var1.var >= var2.var) ? true : false;
        }
        public static bool operator ==(int16_t var1, uint32_t var2)     /* == */
        {
            return (var1.var == var2.var) ? true : false;
        }
        public static bool operator !=(int16_t var1, uint32_t var2)     /* != */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region int64_t
        /* Assignment */
        public static implicit operator int16_t(int64_t obj)
        {
            return new int16_t(obj);
        }

        /* Math */
        public static int16_t operator +(int16_t var1, int64_t var2)    /* + */
        {
            return new int16_t(var1.var + var2.var);
        }
        public static int16_t operator -(int16_t var1, int64_t var2)    /* - */
        {
            return new int16_t(var1.var - var2.var);
        }
        public static int16_t operator *(int16_t var1, int64_t var2)    /* * */
        {
            return new int16_t(var1.var * var2.var);
        }
        public static int16_t operator /(int16_t var1, int64_t var2)    /* / */
        {
            return new int16_t(var1.var / var2.var);
        }
        public static int16_t operator %(int16_t var1, int64_t var2)    /* % */
        {
            return new int16_t(var1.var % var2.var);
        }
        public static int16_t operator &(int16_t var1, int64_t var2)    /* & */
        {
            return new int16_t(var1.var & var2.var);
        }
        public static int16_t operator |(int16_t var1, int64_t var2)    /* | */
        {
            return new int16_t((ushort)var1.var | var2.var);
        }
        public static int16_t operator ^(int16_t var1, int64_t var2)    /* ^ */
        {
            return new int16_t(var1.var ^ var2.var);
        }

        /* Comparison */
        public static bool operator >(int16_t var1, int64_t var2)       /* > */
        {
            return (var1.var > var2.var) ? true : false;
        }
        public static bool operator <(int16_t var1, int64_t var2)       /* < */
        {
            return (var1.var < var2.var) ? true : false;
        }
        public static bool operator <=(int16_t var1, int64_t var2)      /* <= */
        {
            return (var1.var <= var2.var) ? true : false;
        }
        public static bool operator >=(int16_t var1, int64_t var2)      /* >= */
        {
            return (var1.var >= var2.var) ? true : false;
        }
        public static bool operator ==(int16_t var1, int64_t var2)      /* == */
        {
            return (var1.var == var2.var) ? true : false;
        }
        public static bool operator !=(int16_t var1, int64_t var2)      /* != */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region uint64_t
        /* Assignment */
        public static implicit operator int16_t(uint64_t obj)
        {
            return new int16_t(obj);
        }

        /* Math */
        public static int16_t operator +(int16_t var1, uint64_t var2)   /* + */
        {
            return new int16_t((ushort)var1.var + var2.var);
        }
        public static int16_t operator -(int16_t var1, uint64_t var2)   /* - */
        {
            return new int16_t((ushort)var1.var - var2.var);
        }
        public static int16_t operator *(int16_t var1, uint64_t var2)   /* * */
        {
            return new int16_t((ushort)var1.var * var2.var);
        }
        public static int16_t operator /(int16_t var1, uint64_t var2)   /* / */
        {
            return new int16_t((ushort)var1.var / var2.var);
        }
        public static int16_t operator %(int16_t var1, uint64_t var2)   /* % */
        {
            return new int16_t((ushort)var1.var % var2.var);
        }
        public static int16_t operator &(int16_t var1, uint64_t var2)   /* & */
        {
            return new int16_t((ushort)var1.var & var2.var);
        }
        public static int16_t operator |(int16_t var1, uint64_t var2)   /* | */
        {
            return new int16_t((ushort)var1.var | var2.var);
        }
        public static int16_t operator ^(int16_t var1, uint64_t var2)   /* ^ */
        {
            return new int16_t((ushort)var1.var ^ var2.var);
        }

        /* Comparison */
        public static bool operator >(int16_t var1, uint64_t var2)      /* > */
        {
            return (var1.var > (ushort)var2.var) ? true : false;
        }
        public static bool operator <(int16_t var1, uint64_t var2)      /* < */
        {
            return (var1.var < (ushort)var2.var) ? true : false;
        }
        public static bool operator <=(int16_t var1, uint64_t var2)     /* <= */
        {
            return (var1.var <= (ushort)var2.var) ? true : false;
        }
        public static bool operator >=(int16_t var1, uint64_t var2)     /* >= */
        {
            return (var1.var >= (ushort)var2.var) ? true : false;
        }
        public static bool operator ==(int16_t var1, uint64_t var2)     /* == */
        {
            return (var1.var == (ushort)var2.var) ? true : false;
        }
        public static bool operator !=(int16_t var1, uint64_t var2)     /* != */
        {
            return (var1.var != (ushort)var2.var) ? true : false;
        }
        #endregion
        #endregion

        #region default types
        #region sbyte
        /* Assignment */
        public static implicit operator sbyte(int16_t obj)
        {
            return (sbyte)obj.var;
        }

        public static implicit operator int16_t(sbyte var)
        {
            return new int16_t(var);
        }

        /* Math */
        public static int16_t operator +(int16_t var1, sbyte var2)      /* + */
        {
            return new int16_t(var1.var + var2);
        }
        public static int16_t operator -(int16_t var1, sbyte var2)      /* - */
        {
            return new int16_t(var1.var - var2);
        }
        public static int16_t operator *(int16_t var1, sbyte var2)      /* * */
        {
            return new int16_t(var1.var * var2);
        }
        public static int16_t operator /(int16_t var1, sbyte var2)      /* / */
        {
            return new int16_t(var1.var / var2);
        }
        public static int16_t operator %(int16_t var1, sbyte var2)      /* % */
        {
            return new int16_t(var1.var % var2);
        }
        public static int16_t operator &(int16_t var1, sbyte var2)      /* & */
        {
            return new int16_t(var1.var & var2);
        }
        public static int16_t operator |(int16_t var1, sbyte var2)      /* | */
        {
            return new int16_t((ushort)var1.var | (byte)var2);
        }
        public static int16_t operator ^(int16_t var1, sbyte var2)      /* != */
        {
            return new int16_t(var1.var ^ var2);
        }

        /* Comparison */
        public static bool operator >(int16_t var1, sbyte var2)         /* > */
        {
            return (var1.var > var2) ? true : false;
        }
        public static bool operator <(int16_t var1, sbyte var2)         /* < */
        {
            return (var1.var < var2) ? true : false;
        }
        public static bool operator <=(int16_t var1, sbyte var2)        /* <= */
        {
            return (var1.var <= var2) ? true : false;
        }
        public static bool operator >=(int16_t var1, sbyte var2)        /* >= */
        {
            return (var1.var >= var2) ? true : false;
        }
        public static bool operator ==(int16_t var1, sbyte var2)        /* == */
        {
            return (var1.var == var2) ? true : false;
        }
        public static bool operator !=(int16_t var1, sbyte var2)        /* != */
        {
            return (var1.var != var2) ? true : false;
        }
        #endregion
        #region byte
        /* Assignment */
        public static implicit operator byte(int16_t obj)
        {
            return (byte)obj.var;
        }

        public static implicit operator int16_t(byte var)
        {
            return new int16_t(var);
        }

        /* Math */
        public static int16_t operator +(int16_t var1, byte var2)       /* + */
        {
            return new int16_t(var1.var + var2);
        }
        public static int16_t operator -(int16_t var1, byte var2)       /* - */
        {
            return new int16_t(var1.var - var2);
        }
        public static int16_t operator *(int16_t var1, byte var2)       /* * */
        {
            return new int16_t(var1.var * var2);
        }
        public static int16_t operator /(int16_t var1, byte var2)       /* / */
        {
            return new int16_t(var1.var / var2);
        }
        public static int16_t operator %(int16_t var1, byte var2)       /* % */
        {
            return new int16_t(var1.var % var2);
        }
        public static int16_t operator &(int16_t var1, byte var2)       /* & */
        {
            return new int16_t(var1.var & var2);
        }
        public static int16_t operator |(int16_t var1, byte var2)       /* | */
        {
            return new int16_t((ushort)var1.var | var2);
        }
        public static int16_t operator ^(int16_t var1, byte var2)       /* != */
        {
            return new int16_t(var1.var ^ var2);
        }

        /* Comparison */
        public static bool operator >(int16_t var1, byte var2)          /* > */
        {
            return (var1.var > var2) ? true : false;
        }
        public static bool operator <(int16_t var1, byte var2)          /* < */
        {
            return (var1.var < var2) ? true : false;
        }
        public static bool operator <=(int16_t var1, byte var2)         /* <= */
        {
            return (var1.var <= var2) ? true : false;
        }
        public static bool operator >=(int16_t var1, byte var2)         /* >= */
        {
            return (var1.var >= var2) ? true : false;
        }
        public static bool operator ==(int16_t var1, byte var2)         /* == */
        {
            return (var1.var == var2) ? true : false;
        }
        public static bool operator !=(int16_t var1, byte var2)         /* != */
        {
            return (var1.var != var2) ? true : false;
        }
        #endregion
        #region short
        /* Assignment */
        public static implicit operator short(int16_t obj)
        {
            return obj.var;
        }

        public static implicit operator int16_t(short var)
        {
            return new int16_t(var);
        }

        /* Math */
        public static int16_t operator +(int16_t var1, short var2)      /* + */
        {
            return new int16_t(var1.var + var2);
        }
        public static int16_t operator -(int16_t var1, short var2)      /* - */
        {
            return new int16_t(var1.var - var2);
        }
        public static int16_t operator *(int16_t var1, short var2)      /* * */
        {
            return new int16_t(var1.var * var2);
        }
        public static int16_t operator /(int16_t var1, short var2)      /* / */
        {
            return new int16_t(var1.var / var2);
        }
        public static int16_t operator %(int16_t var1, short var2)      /* % */
        {
            return new int16_t(var1.var % var2);
        }
        public static int16_t operator &(int16_t var1, short var2)      /* & */
        {
            return new int16_t(var1.var & var2);
        }
        public static int16_t operator |(int16_t var1, short var2)      /* | */
        {
            return new int16_t(var1.var | var2);
        }
        public static int16_t operator ^(int16_t var1, short var2)      /* != */
        {
            return new int16_t(var1.var ^ var2);
        }

        /* Comparison */
        public static bool operator >(int16_t var1, short var2)         /* > */
        {
            return (var1.var > var2) ? true : false;
        }
        public static bool operator <(int16_t var1, short var2)         /* < */
        {
            return (var1.var < var2) ? true : false;
        }
        public static bool operator <=(int16_t var1, short var2)        /* <= */
        {
            return (var1.var <= var2) ? true : false;
        }
        public static bool operator >=(int16_t var1, short var2)        /* >= */
        {
            return (var1.var >= var2) ? true : false;
        }
        public static bool operator ==(int16_t var1, short var2)        /* == */
        {
            return (var1.var == var2) ? true : false;
        }
        public static bool operator !=(int16_t var1, short var2)        /* != */
        {
            return (var1.var != var2) ? true : false;
        }
        #endregion
        #region ushort
        /* Assignment */
        public static implicit operator ushort(int16_t obj)
        {
            return (ushort)obj.var;
        }

        public static implicit operator int16_t(ushort var)
        {
            return new int16_t(var);
        }

        /* Math */
        public static int16_t operator +(int16_t var1, ushort var2)     /* + */
        {
            return new int16_t(var1.var + var2);
        }
        public static int16_t operator -(int16_t var1, ushort var2)     /* - */
        {
            return new int16_t(var1.var - var2);
        }
        public static int16_t operator *(int16_t var1, ushort var2)     /* * */
        {
            return new int16_t(var1.var * var2);
        }
        public static int16_t operator /(int16_t var1, ushort var2)     /* / */
        {
            return new int16_t(var1.var / var2);
        }
        public static int16_t operator %(int16_t var1, ushort var2)     /* % */
        {
            return new int16_t(var1.var % var2);
        }
        public static int16_t operator &(int16_t var1, ushort var2)     /* & */
        {
            return new int16_t(var1.var & var2);
        }
        public static int16_t operator |(int16_t var1, ushort var2)     /* | */
        {
            return new int16_t((ushort)var1.var | var2);
        }
        public static int16_t operator ^(int16_t var1, ushort var2)     /* != */
        {
            return new int16_t(var1.var ^ var2);
        }

        /* Comparison */
        public static bool operator >(int16_t var1, ushort var2)        /* > */
        {
            return (var1.var > var2) ? true : false;
        }
        public static bool operator <(int16_t var1, ushort var2)        /* < */
        {
            return (var1.var < var2) ? true : false;
        }
        public static bool operator <=(int16_t var1, ushort var2)       /* <= */
        {
            return (var1.var <= var2) ? true : false;
        }
        public static bool operator >=(int16_t var1, ushort var2)       /* >= */
        {
            return (var1.var >= var2) ? true : false;
        }
        public static bool operator ==(int16_t var1, ushort var2)       /* == */
        {
            return (var1.var == var2) ? true : false;
        }
        public static bool operator !=(int16_t var1, ushort var2)       /* != */
        {
            return (var1.var != var2) ? true : false;
        }
        #endregion
        #region int
        /* Assignment */
        public static implicit operator int(int16_t obj)
        {
            return obj.var;
        }

        public static implicit operator int16_t(int var)
        {
            return new int16_t(var);
        }

        /* Math */
        public static int16_t operator +(int16_t var1, int var2)        /* + */
        {
            return new int16_t(var1.var + var2);
        }
        public static int16_t operator -(int16_t var1, int var2)        /* - */
        {
            return new int16_t(var1.var - var2);
        }
        public static int16_t operator *(int16_t var1, int var2)        /* * */
        {
            return new int16_t(var1.var * var2);
        }
        public static int16_t operator /(int16_t var1, int var2)        /* / */
        {
            return new int16_t(var1.var / var2);
        }
        public static int16_t operator %(int16_t var1, int var2)        /* % */
        {
            return new int16_t(var1.var % var2);
        }
        public static int16_t operator &(int16_t var1, int var2)        /* & */
        {
            return new int16_t(var1.var & var2);
        }
        public static int16_t operator |(int16_t var1, int var2)        /* | */
        {
            return new int16_t((ushort)var1.var | (uint)var2);
        }
        public static int16_t operator ^(int16_t var1, int var2)        /* ^ */
        {
            return new int16_t(var1.var ^ var2);
        }
        public static int16_t operator >>(int16_t var1, int var2)       /* >> */
        {
            return new int16_t(var1.var >> var2);
        }
        public static int16_t operator <<(int16_t var1, int var2)       /* << */
        {
            return new int16_t(var1.var << var2);
        }

        /* Comparison */
        public static bool operator >(int16_t var1, int var2)           /* > */
        {
            return (var1.var > var2) ? true : false;
        }
        public static bool operator <(int16_t var1, int var2)           /* < */
        {
            return (var1.var < var2) ? true : false;
        }
        public static bool operator <=(int16_t var1, int var2)          /* <= */
        {
            return (var1.var <= var2) ? true : false;
        }
        public static bool operator >=(int16_t var1, int var2)          /* >= */
        {
            return (var1.var >= var2) ? true : false;
        }
        public static bool operator ==(int16_t var1, int var2)          /* == */
        {
            return (var1.var == var2) ? true : false;
        }
        public static bool operator !=(int16_t var1, int var2)          /* != */
        {
            return (var1.var != var2) ? true : false;
        }
        #endregion
        #region uint
        /* Assignment */
        public static implicit operator uint(int16_t obj)
        {
            return (uint)obj.var;
        }

        public static implicit operator int16_t(uint var)
        {
            return new int16_t(var);
        }

        /* Math */
        public static int16_t operator +(int16_t var1, uint var2)       /* + */
        {
            return new int16_t(var1.var + var2);
        }
        public static int16_t operator -(int16_t var1, uint var2)       /* - */
        {
            return new int16_t(var1.var - var2);
        }
        public static int16_t operator *(int16_t var1, uint var2)       /* * */
        {
            return new int16_t(var1.var * var2);
        }
        public static int16_t operator /(int16_t var1, uint var2)       /* / */
        {
            return new int16_t(var1.var / var2);
        }
        public static int16_t operator %(int16_t var1, uint var2)       /* % */
        {
            return new int16_t(var1.var % var2);
        }
        public static int16_t operator &(int16_t var1, uint var2)       /* & */
        {
            return new int16_t(var1.var & var2);
        }
        public static int16_t operator |(int16_t var1, uint var2)       /* | */
        {
            return new int16_t((ushort)var1.var | var2);
        }
        public static int16_t operator ^(int16_t var1, uint var2)       /* != */
        {
            return new int16_t(var1.var ^ var2);
        }

        /* Comparison */
        public static bool operator >(int16_t var1, uint var2)          /* > */
        {
            return (var1.var > var2) ? true : false;
        }
        public static bool operator <(int16_t var1, uint var2)          /* < */
        {
            return (var1.var < var2) ? true : false;
        }
        public static bool operator <=(int16_t var1, uint var2)         /* <= */
        {
            return (var1.var <= var2) ? true : false;
        }
        public static bool operator >=(int16_t var1, uint var2)         /* >= */
        {
            return (var1.var >= var2) ? true : false;
        }
        public static bool operator ==(int16_t var1, uint var2)         /* == */
        {
            return (var1.var == var2) ? true : false;
        }
        public static bool operator !=(int16_t var1, uint var2)         /* != */
        {
            return (var1.var != var2) ? true : false;
        }
        #endregion
        #region long
        /* Assignment */
        public static implicit operator long(int16_t obj)
        {
            return obj.var;
        }

        public static implicit operator int16_t(long var)
        {
            return new int16_t(var);
        }

        /* Math */
        public static int16_t operator +(int16_t var1, long var2)       /* + */
        {
            return new int16_t(var1.var + var2);
        }
        public static int16_t operator -(int16_t var1, long var2)       /* - */
        {
            return new int16_t(var1.var - var2);
        }
        public static int16_t operator *(int16_t var1, long var2)       /* * */
        {
            return new int16_t(var1.var * var2);
        }
        public static int16_t operator /(int16_t var1, long var2)       /* / */
        {
            return new int16_t(var1.var / var2);
        }
        public static int16_t operator %(int16_t var1, long var2)       /* % */
        {
            return new int16_t(var1.var % var2);
        }
        public static int16_t operator &(int16_t var1, long var2)       /* & */
        {
            return new int16_t(var1.var & var2);
        }
        public static int16_t operator |(int16_t var1, long var2)       /* | */
        {
            return new int16_t((ushort)var1.var | var2);
        }
        public static int16_t operator ^(int16_t var1, long var2)       /* != */
        {
            return new int16_t(var1.var ^ var2);
        }

        /* Comparison */
        public static bool operator >(int16_t var1, long var2)          /* > */
        {
            return (var1.var > var2) ? true : false;
        }
        public static bool operator <(int16_t var1, long var2)          /* < */
        {
            return (var1.var < var2) ? true : false;
        }
        public static bool operator <=(int16_t var1, long var2)         /* <= */
        {
            return (var1.var <= var2) ? true : false;
        }
        public static bool operator >=(int16_t var1, long var2)         /* >= */
        {
            return (var1.var >= var2) ? true : false;
        }
        public static bool operator ==(int16_t var1, long var2)         /* == */
        {
            return (var1.var == var2) ? true : false;
        }
        public static bool operator !=(int16_t var1, long var2)         /* != */
        {
            return (var1.var != var2) ? true : false;
        }
        #endregion
        #region ulong
        /* Assignment */
        public static implicit operator ulong(int16_t obj)
        {
            return (ulong)obj.var;
        }

        public static implicit operator int16_t(ulong var)
        {
            return new int16_t(var);
        }

        /* Math */
        public static int16_t operator +(int16_t var1, ulong var2)      /* + */
        {
            return new int16_t((ushort)var1.var + var2);
        }
        public static int16_t operator -(int16_t var1, ulong var2)      /* - */
        {
            return new int16_t((ushort)var1.var - var2);
        }
        public static int16_t operator *(int16_t var1, ulong var2)      /* * */
        {
            return new int16_t((ushort)var1.var * var2);
        }
        public static int16_t operator /(int16_t var1, ulong var2)      /* / */
        {
            return new int16_t((ushort)var1.var / var2);
        }
        public static int16_t operator %(int16_t var1, ulong var2)      /* % */
        {
            return new int16_t((ushort)var1.var % var2);
        }
        public static int16_t operator &(int16_t var1, ulong var2)      /* & */
        {
            return new int16_t((ushort)var1.var & var2);
        }
        public static int16_t operator |(int16_t var1, ulong var2)      /* | */
        {
            return new int16_t((ushort)var1.var | var2);
        }
        public static int16_t operator ^(int16_t var1, ulong var2)      /* != */
        {
            return new int16_t((ushort)var1.var ^ var2);
        }

        /* Comparison */
        public static bool operator >(int16_t var1, ulong var2)         /* > */
        {
            return ((ushort)var1.var > var2) ? true : false;
        }
        public static bool operator <(int16_t var1, ulong var2)         /* < */
        {
            return ((ushort)var1.var < var2) ? true : false;
        }
        public static bool operator <=(int16_t var1, ulong var2)        /* <= */
        {
            return ((ushort)var1.var <= var2) ? true : false;
        }
        public static bool operator >=(int16_t var1, ulong var2)        /* >= */
        {
            return ((ushort)var1.var >= var2) ? true : false;
        }
        public static bool operator ==(int16_t var1, ulong var2)        /* == */
        {
            return ((ushort)var1.var == var2) ? true : false;
        }
        public static bool operator !=(int16_t var1, ulong var2)        /* != */
        {
            return ((ushort)var1.var != var2) ? true : false;
        }
        #endregion

        #region float
        /* Math */
        public static int16_t operator +(int16_t var1, float var2)      /* + */
        {
            return new int16_t(var1.var + var2);
        }
        public static int16_t operator -(int16_t var1, float var2)      /* - */
        {
            return new int16_t(var1.var - var2);
        }
        public static int16_t operator *(int16_t var1, float var2)      /* * */
        {
            return new int16_t(var1.var * var2);
        }
        public static int16_t operator /(int16_t var1, float var2)      /* / */
        {
            return new int16_t(var1.var / var2);
        }
        public static int16_t operator %(int16_t var1, float var2)      /* % */
        {
            return new int16_t(var1.var % var2);
        }
        public static int16_t operator &(int16_t var1, float var2)      /* & */
        {
            throw new System.ArgumentException(System.String.Format("& operator cannot be applied with float parameter {0}", var2));
        }
        public static int16_t operator |(int16_t var1, float var2)      /* | */
        {
            throw new System.ArgumentException(System.String.Format("| operator cannot be applied with float parameter {0}", var2));
        }
        public static int16_t operator ^(int16_t var1, float var2)      /* != */
        {
            throw new System.ArgumentException(System.String.Format("^ operator cannot be applied with float parameter {0}", var2));
        }

        /* Comparison */
        public static bool operator >(int16_t var1, float var2)         /* > */
        {
            return (var1.var > var2) ? true : false;
        }
        public static bool operator <(int16_t var1, float var2)         /* < */
        {
            return (var1.var < var2) ? true : false;
        }
        public static bool operator <=(int16_t var1, float var2)        /* <= */
        {
            return (var1.var <= var2) ? true : false;
        }
        public static bool operator >=(int16_t var1, float var2)        /* >= */
        {
            return (var1.var >= var2) ? true : false;
        }
        public static bool operator ==(int16_t var1, float var2)        /* == */
        {
            return (var1.var == var2) ? true : false;
        }
        public static bool operator !=(int16_t var1, float var2)        /* != */
        {
            return (var1.var != var2) ? true : false;
        }
        #endregion
        #region double
        /* Math */
        public static int16_t operator +(int16_t var1, double var2)     /* + */
        {
            return new int16_t(var1.var + var2);
        }
        public static int16_t operator -(int16_t var1, double var2)     /* - */
        {
            return new int16_t(var1.var - var2);
        }
        public static int16_t operator *(int16_t var1, double var2)     /* * */
        {
            return new int16_t(var1.var * var2);
        }
        public static int16_t operator /(int16_t var1, double var2)     /* / */
        {
            return new int16_t(var1.var / var2);
        }
        public static int16_t operator %(int16_t var1, double var2)     /* % */
        {
            return new int16_t(var1.var % var2);
        }
        public static int16_t operator &(int16_t var1, double var2)     /* & */
        {
            throw new System.ArgumentException(System.String.Format("& operator cannot be applied with double parameter {0}", var2));
        }
        public static int16_t operator |(int16_t var1, double var2)     /* | */
        {
            throw new System.ArgumentException(System.String.Format("| operator cannot be applied with double parameter {0}", var2));
        }
        public static int16_t operator ^(int16_t var1, double var2)     /* != */
        {
            throw new System.ArgumentException(System.String.Format("^ operator cannot be applied with double parameter {0}", var2));
        }

        /* Comparison */
        public static bool operator >(int16_t var1, double var2)        /* > */
        {
            return (var1.var > var2) ? true : false;
        }
        public static bool operator <(int16_t var1, double var2)        /* < */
        {
            return (var1.var < var2) ? true : false;
        }
        public static bool operator <=(int16_t var1, double var2)       /* <= */
        {
            return (var1.var <= var2) ? true : false;
        }
        public static bool operator >=(int16_t var1, double var2)       /* >= */
        {
            return (var1.var >= var2) ? true : false;
        }
        public static bool operator ==(int16_t var1, double var2)       /* == */
        {
            return (var1.var == var2) ? true : false;
        }
        public static bool operator !=(int16_t var1, double var2)       /* != */
        {
            return (var1.var != var2) ? true : false;
        }
        #endregion
        #endregion
        #endregion

        #region specials
        public override bool Equals(object obj)
        {
            return (obj is int16_t) ? this == (int16_t)obj : false;
        }
        public override int GetHashCode()
        {
            return var;
        }
        public override string ToString()
        {
            return var.ToString();
        }

        public int16_t Increment()
        {
            this.var++;
            return this;
        }
        public int16_t Decrement()
        {
            this.var--;
            return this;
        }
        #endregion
    }

    /***************************** uint16_t **********************************/
    class uint16_t
    {
        public ushort var = 0;

        #region Constructors
        public uint16_t()               { var = 0; }
        public uint16_t(sbyte value)    { var = (ushort)value; }
        public uint16_t(byte value)     { var = (ushort)value; }
        public uint16_t(short value)    { var = (ushort)value; }
        public uint16_t(ushort value)   { var = value; }
        public uint16_t(int value)      { var = (ushort)value; }
        public uint16_t(uint value)     { var = (ushort)value; }
        public uint16_t(long value)     { var = (ushort)value; }
        public uint16_t(ulong value)    { var = (ushort)value; }
        public uint16_t(float value)    { var = System.Convert.ToUInt16(System.Math.Truncate(value)); }
        public uint16_t(double value)   { var = System.Convert.ToUInt16(System.Math.Truncate(value)); }
        public uint16_t(int8_t value)   { var = (ushort)value.var; }
        public uint16_t(uint8_t value)  { var = (ushort)value.var; }
        public uint16_t(int16_t value)  { var = (ushort)value.var; }
        public uint16_t(uint16_t value) { var = value.var; }
        public uint16_t(int32_t value)  { var = (ushort)value.var; }
        public uint16_t(uint32_t value) { var = (ushort)value.var; }
        public uint16_t(int64_t value)  { var = (ushort)value.var; }
        public uint16_t(uint64_t value) { var = (ushort)value.var; }
        #endregion

        #region types
        #region new types
        #region int8_t
        /* Assignment */
        public static implicit operator uint16_t(int8_t obj)
        {
            return new uint16_t(obj);
        }

        /* Math */
        public static uint16_t operator +(uint16_t var1, int8_t var2)   /* + */
        {
            return new uint16_t(var1.var + var2.var);
        }
        public static uint16_t operator -(uint16_t var1, int8_t var2)   /* - */
        {
            return new uint16_t(var1.var - var2.var);
        }
        public static uint16_t operator *(uint16_t var1, int8_t var2)   /* * */
        {
            return new uint16_t(var1.var * var2.var);
        }
        public static uint16_t operator /(uint16_t var1, int8_t var2)   /* / */
        {
            return new uint16_t(var1.var / var2.var);
        }
        public static uint16_t operator %(uint16_t var1, int8_t var2)   /* % */
        {
            return new uint16_t(var1.var % var2.var);
        }
        public static uint16_t operator &(uint16_t var1, int8_t var2)   /* & */
        {
            return new uint16_t(var1.var & var2.var);
        }
        public static uint16_t operator |(uint16_t var1, int8_t var2)   /* | */
        {
            return new uint16_t(var1.var | (byte)var2.var);
        }
        public static uint16_t operator ^(uint16_t var1, int8_t var2)   /* ^ */
        {
            return new uint16_t(var1.var ^ var2.var);
        }

        /* Comparison */
        public static bool operator >(uint16_t var1, int8_t var2)       /* > */
        {
            return (var1.var > var2.var) ? true : false;
        }
        public static bool operator <(uint16_t var1, int8_t var2)       /* < */
        {
            return (var1.var < var2.var) ? true : false;
        }
        public static bool operator <=(uint16_t var1, int8_t var2)      /* <= */
        {
            return (var1.var <= var2.var) ? true : false;
        }
        public static bool operator >=(uint16_t var1, int8_t var2)      /* >= */
        {
            return (var1.var >= var2.var) ? true : false;
        }
        public static bool operator ==(uint16_t var1, int8_t var2)      /* == */
        {
            return (var1.var == var2.var) ? true : false;
        }
        public static bool operator !=(uint16_t var1, int8_t var2)      /* != */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region uint8_t
        /* Assignment */
        public static implicit operator uint16_t(uint8_t obj)
        {
            return new uint16_t(obj);
        }

        /* Math */
        public static uint16_t operator +(uint16_t var1, uint8_t var2)  /* + */
        {
            return new uint16_t(var1.var + var2.var);
        }
        public static uint16_t operator -(uint16_t var1, uint8_t var2)  /* - */
        {
            return new uint16_t(var1.var - var2.var);
        }
        public static uint16_t operator *(uint16_t var1, uint8_t var2)  /* * */
        {
            return new uint16_t(var1.var * var2.var);
        }
        public static uint16_t operator /(uint16_t var1, uint8_t var2)  /* / */
        {
            return new uint16_t(var1.var / var2.var);
        }
        public static uint16_t operator %(uint16_t var1, uint8_t var2)  /* % */
        {
            return new uint16_t(var1.var % var2.var);
        }
        public static uint16_t operator &(uint16_t var1, uint8_t var2)  /* & */
        {
            return new uint16_t(var1.var & var2.var);
        }
        public static uint16_t operator |(uint16_t var1, uint8_t var2)  /* | */
        {
            return new uint16_t(var1.var | var2.var);
        }
        public static uint16_t operator ^(uint16_t var1, uint8_t var2)  /* ^ */
        {
            return new uint16_t(var1.var ^ var2.var);
        }

        /* Comparison */
        public static bool operator >(uint16_t var1, uint8_t var2)      /* > */
        {
            return (var1.var > var2.var) ? true : false;
        }
        public static bool operator <(uint16_t var1, uint8_t var2)      /* < */
        {
            return (var1.var < var2.var) ? true : false;
        }
        public static bool operator <=(uint16_t var1, uint8_t var2)     /* <= */
        {
            return (var1.var <= var2.var) ? true : false;
        }
        public static bool operator >=(uint16_t var1, uint8_t var2)     /* >= */
        {
            return (var1.var >= var2.var) ? true : false;
        }
        public static bool operator ==(uint16_t var1, uint8_t var2)     /* == */
        {
            return (var1.var == var2.var) ? true : false;
        }
        public static bool operator !=(uint16_t var1, uint8_t var2)     /* != */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region int16_t
        /* Assignment */
        public static implicit operator uint16_t(int16_t obj)
        {
            return new uint16_t(obj);
        }

        /* Math */
        public static uint16_t operator +(uint16_t var1, int16_t var2)  /* + */
        {
            return new uint16_t(var1.var + var2.var);
        }
        public static uint16_t operator -(uint16_t var1, int16_t var2)  /* - */
        {
            return new uint16_t(var1.var - var2.var);
        }
        public static uint16_t operator *(uint16_t var1, int16_t var2)  /* * */
        {
            return new uint16_t(var1.var * var2.var);
        }
        public static uint16_t operator /(uint16_t var1, int16_t var2)  /* / */
        {
            return new uint16_t(var1.var / var2.var);
        }
        public static uint16_t operator %(uint16_t var1, int16_t var2)  /* % */
        {
            return new uint16_t(var1.var % var2.var);
        }
        public static uint16_t operator &(uint16_t var1, int16_t var2)  /* & */
        {
            return new uint16_t(var1.var & var2.var);
        }
        public static uint16_t operator |(uint16_t var1, int16_t var2)  /* | */
        {
            return new uint16_t(var1.var | (ushort)var2.var);
        }
        public static uint16_t operator ^(uint16_t var1, int16_t var2)  /* ^ */
        {
            return new uint16_t(var1.var ^ var2.var);
        }

        /* Comparison */
        public static bool operator >(uint16_t var1, int16_t var2)      /* > */
        {
            return (var1.var > var2.var) ? true : false;
        }
        public static bool operator <(uint16_t var1, int16_t var2)      /* < */
        {
            return (var1.var < var2.var) ? true : false;
        }
        public static bool operator <=(uint16_t var1, int16_t var2)     /* <= */
        {
            return (var1.var <= var2.var) ? true : false;
        }
        public static bool operator >=(uint16_t var1, int16_t var2)     /* >= */
        {
            return (var1.var >= var2.var) ? true : false;
        }
        public static bool operator ==(uint16_t var1, int16_t var2)     /* == */
        {
            return (var1.var == var2.var) ? true : false;
        }
        public static bool operator !=(uint16_t var1, int16_t var2)     /* != */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region uint16_t
        /* Unary operators */
        public static uint16_t operator ++(uint16_t obj)                /* ++ */
        {
            obj.Increment();
            return obj;
        }
        public static uint16_t operator --(uint16_t obj)                /* -- */
        {
            obj.Decrement();
            return obj;
        }
        public static uint16_t operator -(uint16_t obj)                 /* - (unary) */
        {
            return new uint16_t(-obj.var);
        }
        public static uint16_t operator +(uint16_t obj)                 /* + (unary) */
        {
            return new uint16_t(obj);
        }
        public static uint16_t operator ~(uint16_t obj)                 /* ~ */
        {
            return new uint16_t(~obj.var);
        }

        /* Math */
        public static uint16_t operator +(uint16_t var1, uint16_t var2) /* + */
        {
            return new uint16_t(var1.var + var2.var);
        }
        public static uint16_t operator -(uint16_t var1, uint16_t var2) /* - */
        {
            return new uint16_t(var1.var - var2.var);
        }
        public static uint16_t operator *(uint16_t var1, uint16_t var2) /* * */
        {
            return new uint16_t(var1.var * var2.var);
        }
        public static uint16_t operator /(uint16_t var1, uint16_t var2) /* / */
        {
            return new uint16_t(var1.var / var2.var);
        }
        public static uint16_t operator %(uint16_t var1, uint16_t var2) /* % */
        {
            return new uint16_t(var1.var % var2.var);
        }
        public static uint16_t operator &(uint16_t var1, uint16_t var2) /* & */
        {
            return new uint16_t(var1.var & var2.var);
        }
        public static uint16_t operator |(uint16_t var1, uint16_t var2) /* | */
        {
            return new uint16_t(var1.var | var2.var);
        }
        public static uint16_t operator ^(uint16_t var1, uint16_t var2) /* ^ */
        {
            return new uint16_t(var1.var ^ var2.var);
        }

        /* Comparison */
        public static bool operator >(uint16_t var1, uint16_t var2)     /* > */
        {
            return (var1.var > var2.var) ? true : false;
        }
        public static bool operator <(uint16_t var1, uint16_t var2)     /* < */
        {
            return (var1.var < var2.var) ? true : false;
        }
        public static bool operator <=(uint16_t var1, uint16_t var2)    /* <= */
        {
            return (var1.var <= var2.var) ? true : false;
        }
        public static bool operator >=(uint16_t var1, uint16_t var2)    /* >= */
        {
            return (var1.var >= var2.var) ? true : false;
        }
        public static bool operator ==(uint16_t var1, uint16_t var2)    /* == */
        {
            return (var1.var == var2.var) ? true : false;
        }
        public static bool operator !=(uint16_t var1, uint16_t var2)    /* != */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region int32_t
        /* Assignment */
        public static implicit operator uint16_t(int32_t obj)
        {
            return new uint16_t(obj);
        }

        /* Math */
        public static uint16_t operator +(uint16_t var1, int32_t var2)  /* + */
        {
            return new uint16_t(var1.var + var2.var);
        }
        public static uint16_t operator -(uint16_t var1, int32_t var2)  /* - */
        {
            return new uint16_t(var1.var - var2.var);
        }
        public static uint16_t operator *(uint16_t var1, int32_t var2)  /* * */
        {
            return new uint16_t(var1.var * var2.var);
        }
        public static uint16_t operator /(uint16_t var1, int32_t var2)  /* / */
        {
            return new uint16_t(var1.var / var2.var);
        }
        public static uint16_t operator %(uint16_t var1, int32_t var2)  /* % */
        {
            return new uint16_t(var1.var % var2.var);
        }
        public static uint16_t operator &(uint16_t var1, int32_t var2)  /* & */
        {
            return new uint16_t(var1.var & var2.var);
        }
        public static uint16_t operator |(uint16_t var1, int32_t var2)  /* | */
        {
            return new uint16_t(var1.var | var2.var);
        }
        public static uint16_t operator ^(uint16_t var1, int32_t var2)  /* ^ */
        {
            return new uint16_t(var1.var ^ var2.var);
        }

        /* Comparison */
        public static bool operator >(uint16_t var1, int32_t var2)      /* > */
        {
            return (var1.var > var2.var) ? true : false;
        }
        public static bool operator <(uint16_t var1, int32_t var2)      /* < */
        {
            return (var1.var < var2.var) ? true : false;
        }
        public static bool operator <=(uint16_t var1, int32_t var2)     /* <= */
        {
            return (var1.var <= var2.var) ? true : false;
        }
        public static bool operator >=(uint16_t var1, int32_t var2)     /* >= */
        {
            return (var1.var >= var2.var) ? true : false;
        }
        public static bool operator ==(uint16_t var1, int32_t var2)     /* == */
        {
            return (var1.var == var2.var) ? true : false;
        }
        public static bool operator !=(uint16_t var1, int32_t var2)     /* != */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region uint32_t
        /* Assignment */
        public static implicit operator uint16_t(uint32_t obj)
        {
            return new uint16_t(obj);
        }

        /* Math */
        public static uint16_t operator +(uint16_t var1, uint32_t var2) /* + */
        {
            return new uint16_t(var1.var + var2.var);
        }
        public static uint16_t operator -(uint16_t var1, uint32_t var2) /* - */
        {
            return new uint16_t(var1.var - var2.var);
        }
        public static uint16_t operator *(uint16_t var1, uint32_t var2) /* * */
        {
            return new uint16_t(var1.var * var2.var);
        }
        public static uint16_t operator /(uint16_t var1, uint32_t var2) /* / */
        {
            return new uint16_t(var1.var / var2.var);
        }
        public static uint16_t operator %(uint16_t var1, uint32_t var2) /* % */
        {
            return new uint16_t(var1.var % var2.var);
        }
        public static uint16_t operator &(uint16_t var1, uint32_t var2) /* & */
        {
            return new uint16_t(var1.var & var2.var);
        }
        public static uint16_t operator |(uint16_t var1, uint32_t var2) /* | */
        {
            return new uint16_t(var1.var | var2.var);
        }
        public static uint16_t operator ^(uint16_t var1, uint32_t var2) /* ^ */
        {
            return new uint16_t(var1.var ^ var2.var);
        }

        /* Comparison */
        public static bool operator >(uint16_t var1, uint32_t var2)     /* > */
        {
            return (var1.var > var2.var) ? true : false;
        }
        public static bool operator <(uint16_t var1, uint32_t var2)     /* < */
        {
            return (var1.var < var2.var) ? true : false;
        }
        public static bool operator <=(uint16_t var1, uint32_t var2)    /* <= */
        {
            return (var1.var <= var2.var) ? true : false;
        }
        public static bool operator >=(uint16_t var1, uint32_t var2)    /* >= */
        {
            return (var1.var >= var2.var) ? true : false;
        }
        public static bool operator ==(uint16_t var1, uint32_t var2)    /* == */
        {
            return (var1.var == var2.var) ? true : false;
        }
        public static bool operator !=(uint16_t var1, uint32_t var2)    /* != */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region int64_t
        /* Assignment */
        public static implicit operator uint16_t(int64_t obj)
        {
            return new uint16_t(obj);
        }

        /* Math */
        public static uint16_t operator +(uint16_t var1, int64_t var2)  /* + */
        {
            return new uint16_t(var1.var + var2.var);
        }
        public static uint16_t operator -(uint16_t var1, int64_t var2)  /* - */
        {
            return new uint16_t(var1.var - var2.var);
        }
        public static uint16_t operator *(uint16_t var1, int64_t var2)  /* * */
        {
            return new uint16_t(var1.var * var2.var);
        }
        public static uint16_t operator /(uint16_t var1, int64_t var2)  /* / */
        {
            return new uint16_t(var1.var / var2.var);
        }
        public static uint16_t operator %(uint16_t var1, int64_t var2)  /* % */
        {
            return new uint16_t(var1.var % var2.var);
        }
        public static uint16_t operator &(uint16_t var1, int64_t var2)  /* & */
        {
            return new uint16_t(var1.var & var2.var);
        }
        public static uint16_t operator |(uint16_t var1, int64_t var2)  /* | */
        {
            return new uint16_t(var1.var | var2.var);
        }
        public static uint16_t operator ^(uint16_t var1, int64_t var2)  /* ^ */
        {
            return new uint16_t(var1.var ^ var2.var);
        }

        /* Comparison */
        public static bool operator >(uint16_t var1, int64_t var2)      /* > */
        {
            return (var1.var > var2.var) ? true : false;
        }
        public static bool operator <(uint16_t var1, int64_t var2)      /* < */
        {
            return (var1.var < var2.var) ? true : false;
        }
        public static bool operator <=(uint16_t var1, int64_t var2)     /* <= */
        {
            return (var1.var <= var2.var) ? true : false;
        }
        public static bool operator >=(uint16_t var1, int64_t var2)     /* >= */
        {
            return (var1.var >= var2.var) ? true : false;
        }
        public static bool operator ==(uint16_t var1, int64_t var2)     /* == */
        {
            return (var1.var == var2.var) ? true : false;
        }
        public static bool operator !=(uint16_t var1, int64_t var2)     /* != */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region uint64_t
        /* Assignment */
        public static implicit operator uint16_t(uint64_t obj)
        {
            return new uint16_t(obj);
        }

        /* Math */
        public static uint16_t operator +(uint16_t var1, uint64_t var2) /* + */
        {
            return new uint16_t(var1.var + var2.var);
        }
        public static uint16_t operator -(uint16_t var1, uint64_t var2) /* - */
        {
            return new uint16_t(var1.var - var2.var);
        }
        public static uint16_t operator *(uint16_t var1, uint64_t var2) /* * */
        {
            return new uint16_t(var1.var * var2.var);
        }
        public static uint16_t operator /(uint16_t var1, uint64_t var2) /* / */
        {
            return new uint16_t(var1.var / var2.var);
        }
        public static uint16_t operator %(uint16_t var1, uint64_t var2) /* % */
        {
            return new uint16_t(var1.var % var2.var);
        }
        public static uint16_t operator &(uint16_t var1, uint64_t var2) /* & */
        {
            return new uint16_t(var1.var & var2.var);
        }
        public static uint16_t operator |(uint16_t var1, uint64_t var2) /* | */
        {
            return new uint16_t(var1.var | var2.var);
        }
        public static uint16_t operator ^(uint16_t var1, uint64_t var2) /* ^ */
        {
            return new uint16_t(var1.var ^ var2.var);
        }

        /* Comparison */
        public static bool operator >(uint16_t var1, uint64_t var2)     /* > */
        {
            return (var1.var > var2.var) ? true : false;
        }
        public static bool operator <(uint16_t var1, uint64_t var2)     /* < */
        {
            return (var1.var < var2.var) ? true : false;
        }
        public static bool operator <=(uint16_t var1, uint64_t var2)    /* <= */
        {
            return (var1.var <= var2.var) ? true : false;
        }
        public static bool operator >=(uint16_t var1, uint64_t var2)    /* >= */
        {
            return (var1.var >= var2.var) ? true : false;
        }
        public static bool operator ==(uint16_t var1, uint64_t var2)    /* == */
        {
            return (var1.var == var2.var) ? true : false;
        }
        public static bool operator !=(uint16_t var1, uint64_t var2)    /* != */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #endregion

        #region default types
        #region sbyte
        /* Assignment */
        public static implicit operator sbyte(uint16_t obj)
        {
            return (sbyte)obj.var;
        }

        public static implicit operator uint16_t(sbyte var)
        {
            return new uint16_t(var);
        }

        /* Math */
        public static uint16_t operator +(uint16_t var1, sbyte var2)    /* + */
        {
            return new uint16_t(var1.var + var2);
        }
        public static uint16_t operator -(uint16_t var1, sbyte var2)    /* - */
        {
            return new uint16_t(var1.var - var2);
        }
        public static uint16_t operator *(uint16_t var1, sbyte var2)    /* * */
        {
            return new uint16_t(var1.var * var2);
        }
        public static uint16_t operator /(uint16_t var1, sbyte var2)    /* / */
        {
            return new uint16_t(var1.var / var2);
        }
        public static uint16_t operator %(uint16_t var1, sbyte var2)    /* % */
        {
            return new uint16_t(var1.var % var2);
        }
        public static uint16_t operator &(uint16_t var1, sbyte var2)    /* & */
        {
            return new uint16_t(var1.var & var2);
        }
        public static uint16_t operator |(uint16_t var1, sbyte var2)    /* | */
        {
            return new uint16_t(var1.var | (byte)var2);
        }
        public static uint16_t operator ^(uint16_t var1, sbyte var2)    /* != */
        {
            return new uint16_t(var1.var ^ var2);
        }

        /* Comparison */
        public static bool operator >(uint16_t var1, sbyte var2)        /* > */
        {
            return (var1.var > var2) ? true : false;
        }
        public static bool operator <(uint16_t var1, sbyte var2)        /* < */
        {
            return (var1.var < var2) ? true : false;
        }
        public static bool operator <=(uint16_t var1, sbyte var2)       /* <= */
        {
            return (var1.var <= var2) ? true : false;
        }
        public static bool operator >=(uint16_t var1, sbyte var2)       /* >= */
        {
            return (var1.var >= var2) ? true : false;
        }
        public static bool operator ==(uint16_t var1, sbyte var2)       /* == */
        {
            return (var1.var == var2) ? true : false;
        }
        public static bool operator !=(uint16_t var1, sbyte var2)       /* != */
        {
            return (var1.var != var2) ? true : false;
        }
        #endregion
        #region byte
        /* Assignment */
        public static implicit operator byte(uint16_t obj)
        {
            return (byte)obj.var;
        }

        public static implicit operator uint16_t(byte var)
        {
            return new uint16_t(var);
        }

        /* Math */
        public static uint16_t operator +(uint16_t var1, byte var2)     /* + */
        {
            return new uint16_t(var1.var + var2);
        }
        public static uint16_t operator -(uint16_t var1, byte var2)     /* - */
        {
            return new uint16_t(var1.var - var2);
        }
        public static uint16_t operator *(uint16_t var1, byte var2)     /* * */
        {
            return new uint16_t(var1.var * var2);
        }
        public static uint16_t operator /(uint16_t var1, byte var2)     /* / */
        {
            return new uint16_t(var1.var / var2);
        }
        public static uint16_t operator %(uint16_t var1, byte var2)     /* % */
        {
            return new uint16_t(var1.var % var2);
        }
        public static uint16_t operator &(uint16_t var1, byte var2)     /* & */
        {
            return new uint16_t(var1.var & var2);
        }
        public static uint16_t operator |(uint16_t var1, byte var2)     /* | */
        {
            return new uint16_t(var1.var | var2);
        }
        public static uint16_t operator ^(uint16_t var1, byte var2)     /* != */
        {
            return new uint16_t(var1.var ^ var2);
        }

        /* Comparison */
        public static bool operator >(uint16_t var1, byte var2)         /* > */
        {
            return (var1.var > var2) ? true : false;
        }
        public static bool operator <(uint16_t var1, byte var2)         /* < */
        {
            return (var1.var < var2) ? true : false;
        }
        public static bool operator <=(uint16_t var1, byte var2)        /* <= */
        {
            return (var1.var <= var2) ? true : false;
        }
        public static bool operator >=(uint16_t var1, byte var2)        /* >= */
        {
            return (var1.var >= var2) ? true : false;
        }
        public static bool operator ==(uint16_t var1, byte var2)        /* == */
        {
            return (var1.var == var2) ? true : false;
        }
        public static bool operator !=(uint16_t var1, byte var2)        /* != */
        {
            return (var1.var != var2) ? true : false;
        }
        #endregion
        #region short
        /* Assignment */
        public static implicit operator short(uint16_t obj)
        {
            return (short)obj.var;
        }

        public static implicit operator uint16_t(short var)
        {
            return new uint16_t(var);
        }

        /* Math */
        public static uint16_t operator +(uint16_t var1, short var2)    /* + */
        {
            return new uint16_t(var1.var + var2);
        }
        public static uint16_t operator -(uint16_t var1, short var2)    /* - */
        {
            return new uint16_t(var1.var - var2);
        }
        public static uint16_t operator *(uint16_t var1, short var2)    /* * */
        {
            return new uint16_t(var1.var * var2);
        }
        public static uint16_t operator /(uint16_t var1, short var2)    /* / */
        {
            return new uint16_t(var1.var / var2);
        }
        public static uint16_t operator %(uint16_t var1, short var2)    /* % */
        {
            return new uint16_t(var1.var % var2);
        }
        public static uint16_t operator &(uint16_t var1, short var2)    /* & */
        {
            return new uint16_t(var1.var & var2);
        }
        public static uint16_t operator |(uint16_t var1, short var2)    /* | */
        {
            return new uint16_t(var1.var | (ushort)var2);
        }
        public static uint16_t operator ^(uint16_t var1, short var2)    /* != */
        {
            return new uint16_t(var1.var ^ var2);
        }

        /* Comparison */
        public static bool operator >(uint16_t var1, short var2)        /* > */
        {
            return (var1.var > var2) ? true : false;
        }
        public static bool operator <(uint16_t var1, short var2)        /* < */
        {
            return (var1.var < var2) ? true : false;
        }
        public static bool operator <=(uint16_t var1, short var2)       /* <= */
        {
            return (var1.var <= var2) ? true : false;
        }
        public static bool operator >=(uint16_t var1, short var2)       /* >= */
        {
            return (var1.var >= var2) ? true : false;
        }
        public static bool operator ==(uint16_t var1, short var2)       /* == */
        {
            return (var1.var == var2) ? true : false;
        }
        public static bool operator !=(uint16_t var1, short var2)       /* != */
        {
            return (var1.var != var2) ? true : false;
        }
        #endregion
        #region ushort
        /* Assignment */
        public static implicit operator ushort(uint16_t obj)
        {
            return (ushort)obj.var;
        }

        public static implicit operator uint16_t(ushort var)
        {
            return new uint16_t(var);
        }

        /* Math */
        public static uint16_t operator +(uint16_t var1, ushort var2)   /* + */
        {
            return new uint16_t(var1.var + var2);
        }
        public static uint16_t operator -(uint16_t var1, ushort var2)   /* - */
        {
            return new uint16_t(var1.var - var2);
        }
        public static uint16_t operator *(uint16_t var1, ushort var2)   /* * */
        {
            return new uint16_t(var1.var * var2);
        }
        public static uint16_t operator /(uint16_t var1, ushort var2)   /* / */
        {
            return new uint16_t(var1.var / var2);
        }
        public static uint16_t operator %(uint16_t var1, ushort var2)   /* % */
        {
            return new uint16_t(var1.var % var2);
        }
        public static uint16_t operator &(uint16_t var1, ushort var2)   /* & */
        {
            return new uint16_t(var1.var & var2);
        }
        public static uint16_t operator |(uint16_t var1, ushort var2)   /* | */
        {
            return new uint16_t(var1.var | var2);
        }
        public static uint16_t operator ^(uint16_t var1, ushort var2)   /* != */
        {
            return new uint16_t(var1.var ^ var2);
        }

        /* Comparison */
        public static bool operator >(uint16_t var1, ushort var2)       /* > */
        {
            return (var1.var > var2) ? true : false;
        }
        public static bool operator <(uint16_t var1, ushort var2)       /* < */
        {
            return (var1.var < var2) ? true : false;
        }
        public static bool operator <=(uint16_t var1, ushort var2)      /* <= */
        {
            return (var1.var <= var2) ? true : false;
        }
        public static bool operator >=(uint16_t var1, ushort var2)      /* >= */
        {
            return (var1.var >= var2) ? true : false;
        }
        public static bool operator ==(uint16_t var1, ushort var2)      /* == */
        {
            return (var1.var == var2) ? true : false;
        }
        public static bool operator !=(uint16_t var1, ushort var2)      /* != */
        {
            return (var1.var != var2) ? true : false;
        }
        #endregion
        #region int
        /* Assignment */
        public static implicit operator int(uint16_t obj)
        {
            return (int)obj.var;
        }

        public static implicit operator uint16_t(int var)
        {
            return new uint16_t(var);
        }

        /* Math */
        public static uint16_t operator +(uint16_t var1, int var2)      /* + */
        {
            return new uint16_t(var1.var + var2);
        }
        public static uint16_t operator -(uint16_t var1, int var2)      /* - */
        {
            return new uint16_t(var1.var - var2);
        }
        public static uint16_t operator *(uint16_t var1, int var2)      /* * */
        {
            return new uint16_t(var1.var * var2);
        }
        public static uint16_t operator /(uint16_t var1, int var2)      /* / */
        {
            return new uint16_t(var1.var / var2);
        }
        public static uint16_t operator %(uint16_t var1, int var2)      /* % */
        {
            return new uint16_t(var1.var % var2);
        }
        public static uint16_t operator &(uint16_t var1, int var2)      /* & */
        {
            return new uint16_t(var1.var & var2);
        }
        public static uint16_t operator |(uint16_t var1, int var2)      /* | */
        {
            return new uint16_t(var1.var | (uint)var2);
        }
        public static uint16_t operator ^(uint16_t var1, int var2)      /* ^ */
        {
            return new uint16_t(var1.var ^ var2);
        }
        public static uint16_t operator >>(uint16_t var1, int var2)     /* >> */
        {
            return new uint16_t(var1.var >> var2);
        }
        public static uint16_t operator <<(uint16_t var1, int var2)     /* << */
        {
            return new uint16_t(var1.var << var2);
        }

        /* Comparison */
        public static bool operator >(uint16_t var1, int var2)          /* > */
        {
            return (var1.var > var2) ? true : false;
        }
        public static bool operator <(uint16_t var1, int var2)          /* < */
        {
            return (var1.var < var2) ? true : false;
        }
        public static bool operator <=(uint16_t var1, int var2)         /* <= */
        {
            return (var1.var <= var2) ? true : false;
        }
        public static bool operator >=(uint16_t var1, int var2)         /* >= */
        {
            return (var1.var >= var2) ? true : false;
        }
        public static bool operator ==(uint16_t var1, int var2)         /* == */
        {
            return (var1.var == var2) ? true : false;
        }
        public static bool operator !=(uint16_t var1, int var2)         /* != */
        {
            return (var1.var != var2) ? true : false;
        }
        #endregion
        #region uint
        /* Assignment */
        public static implicit operator uint(uint16_t obj)
        {
            return (uint)obj.var;
        }

        public static implicit operator uint16_t(uint var)
        {
            return new uint16_t(var);
        }

        /* Math */
        public static uint16_t operator +(uint16_t var1, uint var2)     /* + */
        {
            return new uint16_t(var1.var + var2);
        }
        public static uint16_t operator -(uint16_t var1, uint var2)     /* - */
        {
            return new uint16_t(var1.var - var2);
        }
        public static uint16_t operator *(uint16_t var1, uint var2)     /* * */
        {
            return new uint16_t(var1.var * var2);
        }
        public static uint16_t operator /(uint16_t var1, uint var2)     /* / */
        {
            return new uint16_t(var1.var / var2);
        }
        public static uint16_t operator %(uint16_t var1, uint var2)     /* % */
        {
            return new uint16_t(var1.var % var2);
        }
        public static uint16_t operator &(uint16_t var1, uint var2)     /* & */
        {
            return new uint16_t(var1.var & var2);
        }
        public static uint16_t operator |(uint16_t var1, uint var2)     /* | */
        {
            return new uint16_t(var1.var | var2);
        }
        public static uint16_t operator ^(uint16_t var1, uint var2)     /* != */
        {
            return new uint16_t(var1.var ^ var2);
        }

        /* Comparison */
        public static bool operator >(uint16_t var1, uint var2)         /* > */
        {
            return (var1.var > var2) ? true : false;
        }
        public static bool operator <(uint16_t var1, uint var2)         /* < */
        {
            return (var1.var < var2) ? true : false;
        }
        public static bool operator <=(uint16_t var1, uint var2)        /* <= */
        {
            return (var1.var <= var2) ? true : false;
        }
        public static bool operator >=(uint16_t var1, uint var2)        /* >= */
        {
            return (var1.var >= var2) ? true : false;
        }
        public static bool operator ==(uint16_t var1, uint var2)        /* == */
        {
            return (var1.var == var2) ? true : false;
        }
        public static bool operator !=(uint16_t var1, uint var2)        /* != */
        {
            return (var1.var != var2) ? true : false;
        }
        #endregion
        #region long
        /* Assignment */
        public static implicit operator long(uint16_t obj)
        {
            return (long)obj.var;
        }

        public static implicit operator uint16_t(long var)
        {
            return new uint16_t(var);
        }

        /* Math */
        public static uint16_t operator +(uint16_t var1, long var2)     /* + */
        {
            return new uint16_t(var1.var + var2);
        }
        public static uint16_t operator -(uint16_t var1, long var2)     /* - */
        {
            return new uint16_t(var1.var - var2);
        }
        public static uint16_t operator *(uint16_t var1, long var2)     /* * */
        {
            return new uint16_t(var1.var * var2);
        }
        public static uint16_t operator /(uint16_t var1, long var2)     /* / */
        {
            return new uint16_t(var1.var / var2);
        }
        public static uint16_t operator %(uint16_t var1, long var2)     /* % */
        {
            return new uint16_t(var1.var % var2);
        }
        public static uint16_t operator &(uint16_t var1, long var2)     /* & */
        {
            return new uint16_t(var1.var & var2);
        }
        public static uint16_t operator |(uint16_t var1, long var2)     /* | */
        {
            return new uint16_t(var1.var | var2);
        }
        public static uint16_t operator ^(uint16_t var1, long var2)     /* != */
        {
            return new uint16_t(var1.var ^ var2);
        }

        /* Comparison */
        public static bool operator >(uint16_t var1, long var2)         /* > */
        {
            return (var1.var > var2) ? true : false;
        }
        public static bool operator <(uint16_t var1, long var2)         /* < */
        {
            return (var1.var < var2) ? true : false;
        }
        public static bool operator <=(uint16_t var1, long var2)        /* <= */
        {
            return (var1.var <= var2) ? true : false;
        }
        public static bool operator >=(uint16_t var1, long var2)        /* >= */
        {
            return (var1.var >= var2) ? true : false;
        }
        public static bool operator ==(uint16_t var1, long var2)        /* == */
        {
            return (var1.var == var2) ? true : false;
        }
        public static bool operator !=(uint16_t var1, long var2)        /* != */
        {
            return (var1.var != var2) ? true : false;
        }
        #endregion
        #region ulong
        /* Assignment */
        public static implicit operator ulong(uint16_t obj)
        {
            return (ulong)obj.var;
        }

        public static implicit operator uint16_t(ulong var)
        {
            return new uint16_t(var);
        }

        /* Math */
        public static uint16_t operator +(uint16_t var1, ulong var2)    /* + */
        {
            return new uint16_t(var1.var + var2);
        }
        public static uint16_t operator -(uint16_t var1, ulong var2)    /* - */
        {
            return new uint16_t(var1.var - var2);
        }
        public static uint16_t operator *(uint16_t var1, ulong var2)    /* * */
        {
            return new uint16_t(var1.var * var2);
        }
        public static uint16_t operator /(uint16_t var1, ulong var2)    /* / */
        {
            return new uint16_t(var1.var / var2);
        }
        public static uint16_t operator %(uint16_t var1, ulong var2)    /* % */
        {
            return new uint16_t(var1.var % var2);
        }
        public static uint16_t operator &(uint16_t var1, ulong var2)    /* & */
        {
            return new uint16_t(var1.var & var2);
        }
        public static uint16_t operator |(uint16_t var1, ulong var2)    /* | */
        {
            return new uint16_t(var1.var | var2);
        }
        public static uint16_t operator ^(uint16_t var1, ulong var2)    /* != */
        {
            return new uint16_t(var1.var ^ var2);
        }

        /* Comparison */
        public static bool operator >(uint16_t var1, ulong var2)        /* > */
        {
            return (var1.var > var2) ? true : false;
        }
        public static bool operator <(uint16_t var1, ulong var2)        /* < */
        {
            return (var1.var < var2) ? true : false;
        }
        public static bool operator <=(uint16_t var1, ulong var2)       /* <= */
        {
            return (var1.var <= var2) ? true : false;
        }
        public static bool operator >=(uint16_t var1, ulong var2)       /* >= */
        {
            return (var1.var >= var2) ? true : false;
        }
        public static bool operator ==(uint16_t var1, ulong var2)       /* == */
        {
            return (var1.var == var2) ? true : false;
        }
        public static bool operator !=(uint16_t var1, ulong var2)       /* != */
        {
            return (var1.var != var2) ? true : false;
        }
        #endregion

        #region float
        /* Math */
        public static uint16_t operator +(uint16_t var1, float var2)    /* + */
        {
            return new uint16_t(var1.var + var2);
        }
        public static uint16_t operator -(uint16_t var1, float var2)    /* - */
        {
            return new uint16_t(var1.var - var2);
        }
        public static uint16_t operator *(uint16_t var1, float var2)    /* * */
        {
            return new uint16_t(var1.var * var2);
        }
        public static uint16_t operator /(uint16_t var1, float var2)    /* / */
        {
            return new uint16_t(var1.var / var2);
        }
        public static uint16_t operator %(uint16_t var1, float var2)    /* % */
        {
            return new uint16_t(var1.var % var2);
        }
        public static uint16_t operator &(uint16_t var1, float var2)    /* & */
        {
            throw new System.ArgumentException(System.String.Format("& operator cannot be applied with float parameter {0}", var2));
        }
        public static uint16_t operator |(uint16_t var1, float var2)    /* | */
        {
            throw new System.ArgumentException(System.String.Format("| operator cannot be applied with float parameter {0}", var2));
        }
        public static uint16_t operator ^(uint16_t var1, float var2)    /* != */
        {
            throw new System.ArgumentException(System.String.Format("^ operator cannot be applied with float parameter {0}", var2));
        }

        /* Comparison */
        public static bool operator >(uint16_t var1, float var2)        /* > */
        {
            return (var1.var > var2) ? true : false;
        }
        public static bool operator <(uint16_t var1, float var2)        /* < */
        {
            return (var1.var < var2) ? true : false;
        }
        public static bool operator <=(uint16_t var1, float var2)       /* <= */
        {
            return (var1.var <= var2) ? true : false;
        }
        public static bool operator >=(uint16_t var1, float var2)       /* >= */
        {
            return (var1.var >= var2) ? true : false;
        }
        public static bool operator ==(uint16_t var1, float var2)       /* == */
        {
            return (var1.var == var2) ? true : false;
        }
        public static bool operator !=(uint16_t var1, float var2)       /* != */
        {
            return (var1.var != var2) ? true : false;
        }
        #endregion
        #region double
        /* Math */
        public static uint16_t operator +(uint16_t var1, double var2)   /* + */
        {
            return new uint16_t(var1.var + var2);
        }
        public static uint16_t operator -(uint16_t var1, double var2)   /* - */
        {
            return new uint16_t(var1.var - var2);
        }
        public static uint16_t operator *(uint16_t var1, double var2)   /* * */
        {
            return new uint16_t(var1.var * var2);
        }
        public static uint16_t operator /(uint16_t var1, double var2)   /* / */
        {
            return new uint16_t(var1.var / var2);
        }
        public static uint16_t operator %(uint16_t var1, double var2)   /* % */
        {
            return new uint16_t(var1.var % var2);
        }
        public static uint16_t operator &(uint16_t var1, double var2)   /* & */
        {
            throw new System.ArgumentException(System.String.Format("& operator cannot be applied with double parameter {0}", var2));
        }
        public static uint16_t operator |(uint16_t var1, double var2)   /* | */
        {
            throw new System.ArgumentException(System.String.Format("| operator cannot be applied with double parameter {0}", var2));
        }
        public static uint16_t operator ^(uint16_t var1, double var2)   /* != */
        {
            throw new System.ArgumentException(System.String.Format("^ operator cannot be applied with double parameter {0}", var2));
        }

        /* Comparison */
        public static bool operator >(uint16_t var1, double var2)       /* > */
        {
            return (var1.var > var2) ? true : false;
        }
        public static bool operator <(uint16_t var1, double var2)       /* < */
        {
            return (var1.var < var2) ? true : false;
        }
        public static bool operator <=(uint16_t var1, double var2)      /* <= */
        {
            return (var1.var <= var2) ? true : false;
        }
        public static bool operator >=(uint16_t var1, double var2)      /* >= */
        {
            return (var1.var >= var2) ? true : false;
        }
        public static bool operator ==(uint16_t var1, double var2)      /* == */
        {
            return (var1.var == var2) ? true : false;
        }
        public static bool operator !=(uint16_t var1, double var2)      /* != */
        {
            return (var1.var != var2) ? true : false;
        }
        #endregion
        #endregion
        #endregion

        #region specials
        public override bool Equals(object obj)
        {
            return (obj is uint16_t) ? this == (uint16_t)obj : false;
        }
        public override int GetHashCode()
        {
            return var;
        }
        public override string ToString()
        {
            return var.ToString();
        }

        public uint16_t Increment()
        {
            this.var++;
            return this;
        }
        public uint16_t Decrement()
        {
            this.var--;
            return this;
        }
        #endregion
    }

    /****************************** int32_t **********************************/
    class int32_t
    {
        public int var = 0;

        #region Constructors
        public int32_t()                { var = 0; }
        public int32_t(byte value)      { var = (int)value; }
        public int32_t(sbyte value)     { var = (int)value; }
        public int32_t(short value)     { var = (int)value; }
        public int32_t(ushort value)    { var = (int)value; }
        public int32_t(int value)       { var = value; }
        public int32_t(uint value)      { var = (int)value; }
        public int32_t(long value)      { var = (int)value; }
        public int32_t(ulong value)     { var = (int)value; }
        public int32_t(float value)     { var = System.Convert.ToInt32(System.Math.Truncate(value)); }
        public int32_t(double value)    { var = System.Convert.ToInt32(System.Math.Truncate(value)); }
        public int32_t(int8_t value)    { var = (int)value.var; }
        public int32_t(uint8_t value)   { var = (int)value.var; }
        public int32_t(int16_t value)   { var = (int)value.var; }
        public int32_t(uint16_t value)  { var = (int)value.var; }
        public int32_t(int32_t value)   { var = value.var; }
        public int32_t(uint32_t value)  { var = (int)value.var; }
        public int32_t(int64_t value)   { var = (int)value.var; }
        public int32_t(uint64_t value)  { var = (int)value.var; }
        #endregion

        #region types
        #region new types
        #region int8_t
        /* Assignment */
        public static implicit operator int32_t(int8_t obj)
        {
            return new int32_t(obj);
        }

        /* Math */
        public static int32_t operator +(int32_t var1, int8_t var2)     /* + */
        {
            return new int32_t(var1.var + var2.var);
        }
        public static int32_t operator -(int32_t var1, int8_t var2)     /* - */
        {
            return new int32_t(var1.var - var2.var);
        }
        public static int32_t operator *(int32_t var1, int8_t var2)     /* * */
        {
            return new int32_t(var1.var * var2.var);
        }
        public static int32_t operator /(int32_t var1, int8_t var2)     /* / */
        {
            return new int32_t(var1.var / var2.var);
        }
        public static int32_t operator %(int32_t var1, int8_t var2)     /* % */
        {
            return new int32_t(var1.var % var2.var);
        }
        public static int32_t operator &(int32_t var1, int8_t var2)     /* & */
        {
            return new int32_t(var1.var & var2.var);
        }
        public static int32_t operator |(int32_t var1, int8_t var2)     /* | */
        {
            return new int32_t(var1.var | (byte)var2.var);
        }
        public static int32_t operator ^(int32_t var1, int8_t var2)     /* ^ */
        {
            return new int32_t(var1.var ^ var2.var);
        }

        /* Comparison */
        public static bool operator >(int32_t var1, int8_t var2)        /* > */
        {
            return (var1.var > var2.var) ? true : false;
        }
        public static bool operator <(int32_t var1, int8_t var2)        /* < */
        {
            return (var1.var < var2.var) ? true : false;
        }
        public static bool operator <=(int32_t var1, int8_t var2)       /* <= */
        {
            return (var1.var <= var2.var) ? true : false;
        }
        public static bool operator >=(int32_t var1, int8_t var2)       /* >= */
        {
            return (var1.var >= var2.var) ? true : false;
        }
        public static bool operator ==(int32_t var1, int8_t var2)       /* == */
        {
            return (var1.var == var2.var) ? true : false;
        }
        public static bool operator !=(int32_t var1, int8_t var2)       /* != */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region uint8_t
        /* Assignment */
        public static implicit operator int32_t(uint8_t obj)
        {
            return new int32_t(obj);
        }

        /* Math */
        public static int32_t operator +(int32_t var1, uint8_t var2)    /* + */
        {
            return new int32_t(var1.var + var2.var);
        }
        public static int32_t operator -(int32_t var1, uint8_t var2)    /* - */
        {
            return new int32_t(var1.var - var2.var);
        }
        public static int32_t operator *(int32_t var1, uint8_t var2)    /* * */
        {
            return new int32_t(var1.var * var2.var);
        }
        public static int32_t operator /(int32_t var1, uint8_t var2)    /* / */
        {
            return new int32_t(var1.var / var2.var);
        }
        public static int32_t operator %(int32_t var1, uint8_t var2)    /* % */
        {
            return new int32_t(var1.var % var2.var);
        }
        public static int32_t operator &(int32_t var1, uint8_t var2)    /* & */
        {
            return new int32_t(var1.var & var2.var);
        }
        public static int32_t operator |(int32_t var1, uint8_t var2)    /* | */
        {
            return new int32_t(var1.var | var2.var);
        }
        public static int32_t operator ^(int32_t var1, uint8_t var2)    /* ^ */
        {
            return new int32_t(var1.var ^ var2.var);
        }

        /* Comparison */
        public static bool operator >(int32_t var1, uint8_t var2)       /* > */
        {
            return (var1.var > var2.var) ? true : false;
        }
        public static bool operator <(int32_t var1, uint8_t var2)       /* < */
        {
            return (var1.var < var2.var) ? true : false;
        }
        public static bool operator <=(int32_t var1, uint8_t var2)      /* <= */
        {
            return (var1.var <= var2.var) ? true : false;
        }
        public static bool operator >=(int32_t var1, uint8_t var2)      /* >= */
        {
            return (var1.var >= var2.var) ? true : false;
        }
        public static bool operator ==(int32_t var1, uint8_t var2)      /* == */
        {
            return (var1.var == var2.var) ? true : false;
        }
        public static bool operator !=(int32_t var1, uint8_t var2)      /* != */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region int16_t
        /* Assignment */
        public static implicit operator int32_t(int16_t obj)
        {
            return new int32_t(obj);
        }

        /* Math */
        public static int32_t operator +(int32_t var1, int16_t var2)    /* + */
        {
            return new int32_t(var1.var + var2.var);
        }
        public static int32_t operator -(int32_t var1, int16_t var2)    /* - */
        {
            return new int32_t(var1.var - var2.var);
        }
        public static int32_t operator *(int32_t var1, int16_t var2)    /* * */
        {
            return new int32_t(var1.var * var2.var);
        }
        public static int32_t operator /(int32_t var1, int16_t var2)    /* / */
        {
            return new int32_t(var1.var / var2.var);
        }
        public static int32_t operator %(int32_t var1, int16_t var2)    /* % */
        {
            return new int32_t(var1.var % var2.var);
        }
        public static int32_t operator &(int32_t var1, int16_t var2)    /* & */
        {
            return new int32_t(var1.var & var2.var);
        }
        public static int32_t operator |(int32_t var1, int16_t var2)    /* | */
        {
            return new int32_t(var1.var | (ushort)var2.var);
        }
        public static int32_t operator ^(int32_t var1, int16_t var2)    /* ^ */
        {
            return new int32_t(var1.var ^ var2.var);
        }

        /* Comparison */
        public static bool operator >(int32_t var1, int16_t var2)       /* > */
        {
            return (var1.var > var2.var) ? true : false;
        }
        public static bool operator <(int32_t var1, int16_t var2)       /* < */
        {
            return (var1.var < var2.var) ? true : false;
        }
        public static bool operator <=(int32_t var1, int16_t var2)      /* <= */
        {
            return (var1.var <= var2.var) ? true : false;
        }
        public static bool operator >=(int32_t var1, int16_t var2)      /* >= */
        {
            return (var1.var >= var2.var) ? true : false;
        }
        public static bool operator ==(int32_t var1, int16_t var2)      /* == */
        {
            return (var1.var == var2.var) ? true : false;
        }
        public static bool operator !=(int32_t var1, int16_t var2)      /* != */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region uint16_t
        /* Assignment */
        public static implicit operator int32_t(uint16_t obj)
        {
            return new int32_t(obj);
        }

        /* Math */
        public static int32_t operator +(int32_t var1, uint16_t var2)   /* + */
        {
            return new int32_t(var1.var + var2.var);
        }
        public static int32_t operator -(int32_t var1, uint16_t var2)   /* - */
        {
            return new int32_t(var1.var - var2.var);
        }
        public static int32_t operator *(int32_t var1, uint16_t var2)   /* * */
        {
            return new int32_t(var1.var * var2.var);
        }
        public static int32_t operator /(int32_t var1, uint16_t var2)   /* / */
        {
            return new int32_t(var1.var / var2.var);
        }
        public static int32_t operator %(int32_t var1, uint16_t var2)   /* % */
        {
            return new int32_t(var1.var % var2.var);
        }
        public static int32_t operator &(int32_t var1, uint16_t var2)   /* & */
        {
            return new int32_t(var1.var & var2.var);
        }
        public static int32_t operator |(int32_t var1, uint16_t var2)   /* | */
        {
            return new int32_t(var1.var | var2.var);
        }
        public static int32_t operator ^(int32_t var1, uint16_t var2)   /* ^ */
        {
            return new int32_t(var1.var ^ var2.var);
        }

        /* Comparison */
        public static bool operator >(int32_t var1, uint16_t var2)      /* > */
        {
            return (var1.var > var2.var) ? true : false;
        }
        public static bool operator <(int32_t var1, uint16_t var2)      /* < */
        {
            return (var1.var < var2.var) ? true : false;
        }
        public static bool operator <=(int32_t var1, uint16_t var2)     /* <= */
        {
            return (var1.var <= var2.var) ? true : false;
        }
        public static bool operator >=(int32_t var1, uint16_t var2)     /* >= */
        {
            return (var1.var >= var2.var) ? true : false;
        }
        public static bool operator ==(int32_t var1, uint16_t var2)     /* == */
        {
            return (var1.var == var2.var) ? true : false;
        }
        public static bool operator !=(int32_t var1, uint16_t var2)     /* != */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region int32_t
        /* Unary operators */
        public static int32_t operator ++(int32_t obj)                  /* ++ */
        {
            obj.Increment();
            return obj;
        }
        public static int32_t operator --(int32_t obj)                  /* -- */
        {
            obj.Decrement();
            return obj;
        }
        public static int32_t operator -(int32_t obj)                   /* - (unary) */
        {
            return new int32_t(-obj.var);
        }
        public static int32_t operator +(int32_t obj)                   /* + (unary) */
        {
            return new int32_t(obj);
        }
        public static int32_t operator ~(int32_t obj)                   /* ~ */
        {
            return new int32_t(~obj.var);
        }

        /* Math */
        public static int32_t operator +(int32_t var1, int32_t var2)    /* + */
        {
            return new int32_t(var1.var + var2.var);
        }
        public static int32_t operator -(int32_t var1, int32_t var2)    /* - */
        {
            return new int32_t(var1.var - var2.var);
        }
        public static int32_t operator *(int32_t var1, int32_t var2)    /* * */
        {
            return new int32_t(var1.var * var2.var);
        }
        public static int32_t operator /(int32_t var1, int32_t var2)    /* / */
        {
            return new int32_t(var1.var / var2.var);
        }
        public static int32_t operator %(int32_t var1, int32_t var2)    /* % */
        {
            return new int32_t(var1.var % var2.var);
        }
        public static int32_t operator &(int32_t var1, int32_t var2)    /* & */
        {
            return new int32_t(var1.var & var2.var);
        }
        public static int32_t operator |(int32_t var1, int32_t var2)    /* | */
        {
            return new int32_t(var1.var | var2.var);
        }
        public static int32_t operator ^(int32_t var1, int32_t var2)    /* ^ */
        {
            return new int32_t(var1.var ^ var2.var);
        }

        /* Comparison */
        public static bool operator >(int32_t var1, int32_t var2)       /* > */
        {
            return (var1.var > var2.var) ? true : false;
        }
        public static bool operator <(int32_t var1, int32_t var2)       /* < */
        {
            return (var1.var < var2.var) ? true : false;
        }
        public static bool operator <=(int32_t var1, int32_t var2)      /* <= */
        {
            return (var1.var <= var2.var) ? true : false;
        }
        public static bool operator >=(int32_t var1, int32_t var2)      /* >= */
        {
            return (var1.var >= var2.var) ? true : false;
        }
        public static bool operator ==(int32_t var1, int32_t var2)      /* == */
        {
            return (var1.var == var2.var) ? true : false;
        }
        public static bool operator !=(int32_t var1, int32_t var2)      /* != */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region uint32_t
        /* Assignment */
        public static implicit operator int32_t(uint32_t obj)
        {
            return new int32_t(obj);
        }

        /* Math */
        public static int32_t operator +(int32_t var1, uint32_t var2)    /* + */
        {
            return new int32_t(var1.var + var2.var);
        }
        public static int32_t operator -(int32_t var1, uint32_t var2)   /* - */
        {
            return new int32_t(var1.var - var2.var);
        }
        public static int32_t operator *(int32_t var1, uint32_t var2)   /* * */
        {
            return new int32_t(var1.var * var2.var);
        }
        public static int32_t operator /(int32_t var1, uint32_t var2)   /* / */
        {
            return new int32_t(var1.var / var2.var);
        }
        public static int32_t operator %(int32_t var1, uint32_t var2)   /* % */
        {
            return new int32_t(var1.var % var2.var);
        }
        public static int32_t operator &(int32_t var1, uint32_t var2)   /* & */
        {
            return new int32_t(var1.var & var2.var);
        }
        public static int32_t operator |(int32_t var1, uint32_t var2)   /* | */
        {
            return new int32_t((uint)var1.var | var2.var);
        }
        public static int32_t operator ^(int32_t var1, uint32_t var2)   /* ^ */
        {
            return new int32_t(var1.var ^ var2.var);
        }

        /* Comparison */
        public static bool operator >(int32_t var1, uint32_t var2)      /* > */
        {
            return (var1.var > var2.var) ? true : false;
        }
        public static bool operator <(int32_t var1, uint32_t var2)      /* < */
        {
            return (var1.var < var2.var) ? true : false;
        }
        public static bool operator <=(int32_t var1, uint32_t var2)     /* <= */
        {
            return (var1.var <= var2.var) ? true : false;
        }
        public static bool operator >=(int32_t var1, uint32_t var2)     /* >= */
        {
            return (var1.var >= var2.var) ? true : false;
        }
        public static bool operator ==(int32_t var1, uint32_t var2)     /* == */
        {
            return (var1.var == var2.var) ? true : false;
        }
        public static bool operator !=(int32_t var1, uint32_t var2)     /* != */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region int64_t
        /* Assignment */
        public static implicit operator int32_t(int64_t obj)
        {
            return new int32_t(obj);
        }

        /* Math */
        public static int32_t operator +(int32_t var1, int64_t var2)    /* + */
        {
            return new int32_t(var1.var + var2.var);
        }
        public static int32_t operator -(int32_t var1, int64_t var2)    /* - */
        {
            return new int32_t(var1.var - var2.var);
        }
        public static int32_t operator *(int32_t var1, int64_t var2)    /* * */
        {
            return new int32_t(var1.var * var2.var);
        }
        public static int32_t operator /(int32_t var1, int64_t var2)    /* / */
        {
            return new int32_t(var1.var / var2.var);
        }
        public static int32_t operator %(int32_t var1, int64_t var2)    /* % */
        {
            return new int32_t(var1.var % var2.var);
        }
        public static int32_t operator &(int32_t var1, int64_t var2)    /* & */
        {
            return new int32_t(var1.var & var2.var);
        }
        public static int32_t operator |(int32_t var1, int64_t var2)    /* | */
        {
            return new int32_t((uint)var1.var | var2.var);
        }
        public static int32_t operator ^(int32_t var1, int64_t var2)    /* ^ */
        {
            return new int32_t(var1.var ^ var2.var);
        }

        /* Comparison */
        public static bool operator >(int32_t var1, int64_t var2)       /* > */
        {
            return (var1.var > var2.var) ? true : false;
        }
        public static bool operator <(int32_t var1, int64_t var2)       /* < */
        {
            return (var1.var < var2.var) ? true : false;
        }
        public static bool operator <=(int32_t var1, int64_t var2)      /* <= */
        {
            return (var1.var <= var2.var) ? true : false;
        }
        public static bool operator >=(int32_t var1, int64_t var2)      /* >= */
        {
            return (var1.var >= var2.var) ? true : false;
        }
        public static bool operator ==(int32_t var1, int64_t var2)      /* == */
        {
            return (var1.var == var2.var) ? true : false;
        }
        public static bool operator !=(int32_t var1, int64_t var2)      /* != */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region uint64_t
        /* Assignment */
        public static implicit operator int32_t(uint64_t obj)
        {
            return new int32_t(obj);
        }

        /* Math */
        public static int32_t operator +(int32_t var1, uint64_t var2)   /* + */
        {
            return new int32_t((uint)var1.var + var2.var);
        }
        public static int32_t operator -(int32_t var1, uint64_t var2)   /* - */
        {
            return new int32_t((uint)var1.var - var2.var);
        }
        public static int32_t operator *(int32_t var1, uint64_t var2)   /* * */
        {
            return new int32_t((uint)var1.var * var2.var);
        }
        public static int32_t operator /(int32_t var1, uint64_t var2)   /* / */
        {
            return new int32_t((uint)var1.var / var2.var);
        }
        public static int32_t operator %(int32_t var1, uint64_t var2)   /* % */
        {
            return new int32_t((uint)var1.var % var2.var);
        }
        public static int32_t operator &(int32_t var1, uint64_t var2)   /* & */
        {
            return new int32_t((uint)var1.var & var2.var);
        }
        public static int32_t operator |(int32_t var1, uint64_t var2)   /* | */
        {
            return new int32_t((uint)var1.var | var2.var);
        }
        public static int32_t operator ^(int32_t var1, uint64_t var2)   /* ^ */
        {
            return new int32_t((uint)var1.var ^ var2.var);
        }

        /* Comparison */
        public static bool operator >(int32_t var1, uint64_t var2)      /* > */
        {
            return (var1.var > (uint)var2.var) ? true : false;
        }
        public static bool operator <(int32_t var1, uint64_t var2)      /* < */
        {
            return (var1.var < (uint)var2.var) ? true : false;
        }
        public static bool operator <=(int32_t var1, uint64_t var2)     /* <= */
        {
            return (var1.var <= (uint)var2.var) ? true : false;
        }
        public static bool operator >=(int32_t var1, uint64_t var2)     /* >= */
        {
            return (var1.var >= (uint)var2.var) ? true : false;
        }
        public static bool operator ==(int32_t var1, uint64_t var2)     /* == */
        {
            return (var1.var == (uint)var2.var) ? true : false;
        }
        public static bool operator !=(int32_t var1, uint64_t var2)     /* != */
        {
            return (var1.var != (uint)var2.var) ? true : false;
        }
        #endregion
        #endregion

        #region default types
        #region sbyte
        /* Assignment */
        public static implicit operator sbyte(int32_t obj)
        {
            return (sbyte)obj.var;
        }

        public static implicit operator int32_t(sbyte var)
        {
            return new int32_t(var);
        }

        /* Math */
        public static int32_t operator +(int32_t var1, sbyte var2)      /* + */
        {
            return new int32_t(var1.var + var2);
        }
        public static int32_t operator -(int32_t var1, sbyte var2)      /* - */
        {
            return new int32_t(var1.var - var2);
        }
        public static int32_t operator *(int32_t var1, sbyte var2)      /* * */
        {
            return new int32_t(var1.var * var2);
        }
        public static int32_t operator /(int32_t var1, sbyte var2)      /* / */
        {
            return new int32_t(var1.var / var2);
        }
        public static int32_t operator %(int32_t var1, sbyte var2)      /* % */
        {
            return new int32_t(var1.var % var2);
        }
        public static int32_t operator &(int32_t var1, sbyte var2)      /* & */
        {
            return new int32_t(var1.var & var2);
        }
        public static int32_t operator |(int32_t var1, sbyte var2)      /* | */
        {
            return new int32_t(var1.var | (byte)var2);
        }
        public static int32_t operator ^(int32_t var1, sbyte var2)      /* != */
        {
            return new int32_t(var1.var ^ var2);
        }

        /* Comparison */
        public static bool operator >(int32_t var1, sbyte var2)         /* > */
        {
            return (var1.var > var2) ? true : false;
        }
        public static bool operator <(int32_t var1, sbyte var2)         /* < */
        {
            return (var1.var < var2) ? true : false;
        }
        public static bool operator <=(int32_t var1, sbyte var2)        /* <= */
        {
            return (var1.var <= var2) ? true : false;
        }
        public static bool operator >=(int32_t var1, sbyte var2)        /* >= */
        {
            return (var1.var >= var2) ? true : false;
        }
        public static bool operator ==(int32_t var1, sbyte var2)        /* == */
        {
            return (var1.var == var2) ? true : false;
        }
        public static bool operator !=(int32_t var1, sbyte var2)        /* != */
        {
            return (var1.var != var2) ? true : false;
        }
        #endregion
        #region byte
        /* Assignment */
        public static implicit operator byte(int32_t obj)
        {
            return (byte)obj.var;
        }

        public static implicit operator int32_t(byte var)
        {
            return new int32_t(var);
        }

        /* Math */
        public static int32_t operator +(int32_t var1, byte var2)       /* + */
        {
            return new int32_t(var1.var + var2);
        }
        public static int32_t operator -(int32_t var1, byte var2)       /* - */
        {
            return new int32_t(var1.var - var2);
        }
        public static int32_t operator *(int32_t var1, byte var2)       /* * */
        {
            return new int32_t(var1.var * var2);
        }
        public static int32_t operator /(int32_t var1, byte var2)       /* / */
        {
            return new int32_t(var1.var / var2);
        }
        public static int32_t operator %(int32_t var1, byte var2)       /* % */
        {
            return new int32_t(var1.var % var2);
        }
        public static int32_t operator &(int32_t var1, byte var2)       /* & */
        {
            return new int32_t(var1.var & var2);
        }
        public static int32_t operator |(int32_t var1, byte var2)       /* | */
        {
            return new int32_t(var1.var | var2);
        }
        public static int32_t operator ^(int32_t var1, byte var2)       /* != */
        {
            return new int32_t(var1.var ^ var2);
        }

        /* Comparison */
        public static bool operator >(int32_t var1, byte var2)          /* > */
        {
            return (var1.var > var2) ? true : false;
        }
        public static bool operator <(int32_t var1, byte var2)          /* < */
        {
            return (var1.var < var2) ? true : false;
        }
        public static bool operator <=(int32_t var1, byte var2)         /* <= */
        {
            return (var1.var <= var2) ? true : false;
        }
        public static bool operator >=(int32_t var1, byte var2)         /* >= */
        {
            return (var1.var >= var2) ? true : false;
        }
        public static bool operator ==(int32_t var1, byte var2)         /* == */
        {
            return (var1.var == var2) ? true : false;
        }
        public static bool operator !=(int32_t var1, byte var2)         /* != */
        {
            return (var1.var != var2) ? true : false;
        }
        #endregion
        #region short
        /* Assignment */
        public static implicit operator short(int32_t obj)
        {
            return (short)obj.var;
        }

        public static implicit operator int32_t(short var)
        {
            return new int32_t(var);
        }

        /* Math */
        public static int32_t operator +(int32_t var1, short var2)      /* + */
        {
            return new int32_t(var1.var + var2);
        }
        public static int32_t operator -(int32_t var1, short var2)      /* - */
        {
            return new int32_t(var1.var - var2);
        }
        public static int32_t operator *(int32_t var1, short var2)      /* * */
        {
            return new int32_t(var1.var * var2);
        }
        public static int32_t operator /(int32_t var1, short var2)      /* / */
        {
            return new int32_t(var1.var / var2);
        }
        public static int32_t operator %(int32_t var1, short var2)      /* % */
        {
            return new int32_t(var1.var % var2);
        }
        public static int32_t operator &(int32_t var1, short var2)      /* & */
        {
            return new int32_t(var1.var & var2);
        }
        public static int32_t operator |(int32_t var1, short var2)      /* | */
        {
            return new int32_t(var1.var | (ushort)var2);
        }
        public static int32_t operator ^(int32_t var1, short var2)      /* != */
        {
            return new int32_t(var1.var ^ var2);
        }

        /* Comparison */
        public static bool operator >(int32_t var1, short var2)         /* > */
        {
            return (var1.var > var2) ? true : false;
        }
        public static bool operator <(int32_t var1, short var2)         /* < */
        {
            return (var1.var < var2) ? true : false;
        }
        public static bool operator <=(int32_t var1, short var2)        /* <= */
        {
            return (var1.var <= var2) ? true : false;
        }
        public static bool operator >=(int32_t var1, short var2)        /* >= */
        {
            return (var1.var >= var2) ? true : false;
        }
        public static bool operator ==(int32_t var1, short var2)        /* == */
        {
            return (var1.var == var2) ? true : false;
        }
        public static bool operator !=(int32_t var1, short var2)        /* != */
        {
            return (var1.var != var2) ? true : false;
        }
        #endregion
        #region ushort
        /* Assignment */
        public static implicit operator ushort(int32_t obj)
        {
            return (ushort)obj.var;
        }

        public static implicit operator int32_t(ushort var)
        {
            return new int32_t(var);
        }

        /* Math */
        public static int32_t operator +(int32_t var1, ushort var2)     /* + */
        {
            return new int32_t(var1.var + var2);
        }
        public static int32_t operator -(int32_t var1, ushort var2)     /* - */
        {
            return new int32_t(var1.var - var2);
        }
        public static int32_t operator *(int32_t var1, ushort var2)     /* * */
        {
            return new int32_t(var1.var * var2);
        }
        public static int32_t operator /(int32_t var1, ushort var2)     /* / */
        {
            return new int32_t(var1.var / var2);
        }
        public static int32_t operator %(int32_t var1, ushort var2)     /* % */
        {
            return new int32_t(var1.var % var2);
        }
        public static int32_t operator &(int32_t var1, ushort var2)     /* & */
        {
            return new int32_t(var1.var & var2);
        }
        public static int32_t operator |(int32_t var1, ushort var2)     /* | */
        {
            return new int32_t(var1.var | var2);
        }
        public static int32_t operator ^(int32_t var1, ushort var2)     /* != */
        {
            return new int32_t(var1.var ^ var2);
        }

        /* Comparison */
        public static bool operator >(int32_t var1, ushort var2)        /* > */
        {
            return (var1.var > var2) ? true : false;
        }
        public static bool operator <(int32_t var1, ushort var2)        /* < */
        {
            return (var1.var < var2) ? true : false;
        }
        public static bool operator <=(int32_t var1, ushort var2)       /* <= */
        {
            return (var1.var <= var2) ? true : false;
        }
        public static bool operator >=(int32_t var1, ushort var2)       /* >= */
        {
            return (var1.var >= var2) ? true : false;
        }
        public static bool operator ==(int32_t var1, ushort var2)       /* == */
        {
            return (var1.var == var2) ? true : false;
        }
        public static bool operator !=(int32_t var1, ushort var2)       /* != */
        {
            return (var1.var != var2) ? true : false;
        }
        #endregion
        #region int
        /* Assignment */
        public static implicit operator int(int32_t obj)
        {
            return obj.var;
        }

        public static implicit operator int32_t(int var)
        {
            return new int32_t(var);
        }

        /* Math */
        public static int32_t operator +(int32_t var1, int var2)        /* + */
        {
            return new int32_t(var1.var + var2);
        }
        public static int32_t operator -(int32_t var1, int var2)        /* - */
        {
            return new int32_t(var1.var - var2);
        }
        public static int32_t operator *(int32_t var1, int var2)        /* * */
        {
            return new int32_t(var1.var * var2);
        }
        public static int32_t operator /(int32_t var1, int var2)        /* / */
        {
            return new int32_t(var1.var / var2);
        }
        public static int32_t operator %(int32_t var1, int var2)        /* % */
        {
            return new int32_t(var1.var % var2);
        }
        public static int32_t operator &(int32_t var1, int var2)        /* & */
        {
            return new int32_t(var1.var & var2);
        }
        public static int32_t operator |(int32_t var1, int var2)        /* | */
        {
            return new int32_t(var1.var | var2);
        }
        public static int32_t operator ^(int32_t var1, int var2)        /* ^ */
        {
            return new int32_t(var1.var ^ var2);
        }
        public static int32_t operator >>(int32_t var1, int var2)       /* >> */
        {
            return new int32_t(var1.var >> var2);
        }
        public static int32_t operator <<(int32_t var1, int var2)       /* << */
        {
            return new int32_t(var1.var << var2);
        }

        /* Comparison */
        public static bool operator >(int32_t var1, int var2)           /* > */
        {
            return (var1.var > var2) ? true : false;
        }
        public static bool operator <(int32_t var1, int var2)           /* < */
        {
            return (var1.var < var2) ? true : false;
        }
        public static bool operator <=(int32_t var1, int var2)          /* <= */
        {
            return (var1.var <= var2) ? true : false;
        }
        public static bool operator >=(int32_t var1, int var2)          /* >= */
        {
            return (var1.var >= var2) ? true : false;
        }
        public static bool operator ==(int32_t var1, int var2)          /* == */
        {
            return (var1.var == var2) ? true : false;
        }
        public static bool operator !=(int32_t var1, int var2)          /* != */
        {
            return (var1.var != var2) ? true : false;
        }
        #endregion
        #region uint
        /* Assignment */
        public static implicit operator uint(int32_t obj)
        {
            return (uint)obj.var;
        }

        public static implicit operator int32_t(uint var)
        {
            return new int32_t(var);
        }

        /* Math */
        public static int32_t operator +(int32_t var1, uint var2)       /* + */
        {
            return new int32_t(var1.var + var2);
        }
        public static int32_t operator -(int32_t var1, uint var2)       /* - */
        {
            return new int32_t(var1.var - var2);
        }
        public static int32_t operator *(int32_t var1, uint var2)       /* * */
        {
            return new int32_t(var1.var * var2);
        }
        public static int32_t operator /(int32_t var1, uint var2)       /* / */
        {
            return new int32_t(var1.var / var2);
        }
        public static int32_t operator %(int32_t var1, uint var2)       /* % */
        {
            return new int32_t(var1.var % var2);
        }
        public static int32_t operator &(int32_t var1, uint var2)       /* & */
        {
            return new int32_t(var1.var & var2);
        }
        public static int32_t operator |(int32_t var1, uint var2)       /* | */
        {
            return new int32_t((uint)var1.var | var2);
        }
        public static int32_t operator ^(int32_t var1, uint var2)       /* != */
        {
            return new int32_t(var1.var ^ var2);
        }

        /* Comparison */
        public static bool operator >(int32_t var1, uint var2)          /* > */
        {
            return (var1.var > var2) ? true : false;
        }
        public static bool operator <(int32_t var1, uint var2)          /* < */
        {
            return (var1.var < var2) ? true : false;
        }
        public static bool operator <=(int32_t var1, uint var2)         /* <= */
        {
            return (var1.var <= var2) ? true : false;
        }
        public static bool operator >=(int32_t var1, uint var2)         /* >= */
        {
            return (var1.var >= var2) ? true : false;
        }
        public static bool operator ==(int32_t var1, uint var2)         /* == */
        {
            return (var1.var == var2) ? true : false;
        }
        public static bool operator !=(int32_t var1, uint var2)         /* != */
        {
            return (var1.var != var2) ? true : false;
        }
        #endregion
        #region long
        /* Assignment */
        public static implicit operator long(int32_t obj)
        {
            return obj.var;
        }

        public static implicit operator int32_t(long var)
        {
            return new int32_t(var);
        }

        /* Math */
        public static int32_t operator +(int32_t var1, long var2)       /* + */
        {
            return new int32_t(var1.var + var2);
        }
        public static int32_t operator -(int32_t var1, long var2)       /* - */
        {
            return new int32_t(var1.var - var2);
        }
        public static int32_t operator *(int32_t var1, long var2)       /* * */
        {
            return new int32_t(var1.var * var2);
        }
        public static int32_t operator /(int32_t var1, long var2)       /* / */
        {
            return new int32_t(var1.var / var2);
        }
        public static int32_t operator %(int32_t var1, long var2)       /* % */
        {
            return new int32_t(var1.var % var2);
        }
        public static int32_t operator &(int32_t var1, long var2)       /* & */
        {
            return new int32_t(var1.var & var2);
        }
        public static int32_t operator |(int32_t var1, long var2)       /* | */
        {
            return new int32_t((uint)var1.var | var2);
        }
        public static int32_t operator ^(int32_t var1, long var2)       /* != */
        {
            return new int32_t(var1.var ^ var2);
        }

        /* Comparison */
        public static bool operator >(int32_t var1, long var2)          /* > */
        {
            return (var1.var > var2) ? true : false;
        }
        public static bool operator <(int32_t var1, long var2)          /* < */
        {
            return (var1.var < var2) ? true : false;
        }
        public static bool operator <=(int32_t var1, long var2)         /* <= */
        {
            return (var1.var <= var2) ? true : false;
        }
        public static bool operator >=(int32_t var1, long var2)         /* >= */
        {
            return (var1.var >= var2) ? true : false;
        }
        public static bool operator ==(int32_t var1, long var2)         /* == */
        {
            return (var1.var == var2) ? true : false;
        }
        public static bool operator !=(int32_t var1, long var2)         /* != */
        {
            return (var1.var != var2) ? true : false;
        }
        #endregion
        #region ulong
        /* Assignment */
        public static implicit operator ulong(int32_t obj)
        {
            return (ulong)obj.var;
        }

        public static implicit operator int32_t(ulong var)
        {
            return new int32_t(var);
        }

        /* Math */
        public static int32_t operator +(int32_t var1, ulong var2)      /* + */
        {
            return new int32_t((uint)var1.var + var2);
        }
        public static int32_t operator -(int32_t var1, ulong var2)      /* - */
        {
            return new int32_t((uint)var1.var - var2);
        }
        public static int32_t operator *(int32_t var1, ulong var2)      /* * */
        {
            return new int32_t((uint)var1.var * var2);
        }
        public static int32_t operator /(int32_t var1, ulong var2)      /* / */
        {
            return new int32_t((uint)var1.var / var2);
        }
        public static int32_t operator %(int32_t var1, ulong var2)      /* % */
        {
            return new int32_t((uint)var1.var % var2);
        }
        public static int32_t operator &(int32_t var1, ulong var2)      /* & */
        {
            return new int32_t((uint)var1.var & var2);
        }
        public static int32_t operator |(int32_t var1, ulong var2)      /* | */
        {
            return new int32_t((uint)var1.var | var2);
        }
        public static int32_t operator ^(int32_t var1, ulong var2)      /* != */
        {
            return new int32_t((uint)var1.var ^ var2);
        }

        /* Comparison */
        public static bool operator >(int32_t var1, ulong var2)         /* > */
        {
            return ((uint)var1.var > var2) ? true : false;
        }
        public static bool operator <(int32_t var1, ulong var2)         /* < */
        {
            return ((uint)var1.var < var2) ? true : false;
        }
        public static bool operator <=(int32_t var1, ulong var2)        /* <= */
        {
            return ((uint)var1.var <= var2) ? true : false;
        }
        public static bool operator >=(int32_t var1, ulong var2)        /* >= */
        {
            return ((uint)var1.var >= var2) ? true : false;
        }
        public static bool operator ==(int32_t var1, ulong var2)        /* == */
        {
            return ((uint)var1.var == var2) ? true : false;
        }
        public static bool operator !=(int32_t var1, ulong var2)        /* != */
        {
            return ((uint)var1.var != var2) ? true : false;
        }
        #endregion

        #region float
        /* Math */
        public static int32_t operator +(int32_t var1, float var2)      /* + */
        {
            return new int32_t(var1.var + var2);
        }
        public static int32_t operator -(int32_t var1, float var2)      /* - */
        {
            return new int32_t(var1.var - var2);
        }
        public static int32_t operator *(int32_t var1, float var2)      /* * */
        {
            return new int32_t(var1.var * var2);
        }
        public static int32_t operator /(int32_t var1, float var2)      /* / */
        {
            return new int32_t(var1.var / var2);
        }
        public static int32_t operator %(int32_t var1, float var2)      /* % */
        {
            return new int32_t(var1.var % var2);
        }
        public static int32_t operator &(int32_t var1, float var2)      /* & */
        {
            throw new System.ArgumentException(System.String.Format("& operator cannot be applied with float parameter {0}", var2));
        }
        public static int32_t operator |(int32_t var1, float var2)      /* | */
        {
            throw new System.ArgumentException(System.String.Format("| operator cannot be applied with float parameter {0}", var2));
        }
        public static int32_t operator ^(int32_t var1, float var2)      /* != */
        {
            throw new System.ArgumentException(System.String.Format("^ operator cannot be applied with float parameter {0}", var2));
        }

        /* Comparison */
        public static bool operator >(int32_t var1, float var2)         /* > */
        {
            return (var1.var > var2) ? true : false;
        }
        public static bool operator <(int32_t var1, float var2)         /* < */
        {
            return (var1.var < var2) ? true : false;
        }
        public static bool operator <=(int32_t var1, float var2)        /* <= */
        {
            return (var1.var <= var2) ? true : false;
        }
        public static bool operator >=(int32_t var1, float var2)        /* >= */
        {
            return (var1.var >= var2) ? true : false;
        }
        public static bool operator ==(int32_t var1, float var2)        /* == */
        {
            return (var1.var == var2) ? true : false;
        }
        public static bool operator !=(int32_t var1, float var2)        /* != */
        {
            return (var1.var != var2) ? true : false;
        }
        #endregion
        #region double
        /* Math */
        public static int32_t operator +(int32_t var1, double var2)     /* + */
        {
            return new int32_t(var1.var + var2);
        }
        public static int32_t operator -(int32_t var1, double var2)     /* - */
        {
            return new int32_t(var1.var - var2);
        }
        public static int32_t operator *(int32_t var1, double var2)     /* * */
        {
            return new int32_t(var1.var * var2);
        }
        public static int32_t operator /(int32_t var1, double var2)     /* / */
        {
            return new int32_t(var1.var / var2);
        }
        public static int32_t operator %(int32_t var1, double var2)     /* % */
        {
            return new int32_t(var1.var % var2);
        }
        public static int32_t operator &(int32_t var1, double var2)     /* & */
        {
            throw new System.ArgumentException(System.String.Format("& operator cannot be applied with double parameter {0}", var2));
        }
        public static int32_t operator |(int32_t var1, double var2)     /* | */
        {
            throw new System.ArgumentException(System.String.Format("| operator cannot be applied with double parameter {0}", var2));
        }
        public static int32_t operator ^(int32_t var1, double var2)     /* != */
        {
            throw new System.ArgumentException(System.String.Format("^ operator cannot be applied with double parameter {0}", var2));
        }

        /* Comparison */
        public static bool operator >(int32_t var1, double var2)        /* > */
        {
            return (var1.var > var2) ? true : false;
        }
        public static bool operator <(int32_t var1, double var2)        /* < */
        {
            return (var1.var < var2) ? true : false;
        }
        public static bool operator <=(int32_t var1, double var2)       /* <= */
        {
            return (var1.var <= var2) ? true : false;
        }
        public static bool operator >=(int32_t var1, double var2)       /* >= */
        {
            return (var1.var >= var2) ? true : false;
        }
        public static bool operator ==(int32_t var1, double var2)       /* == */
        {
            return (var1.var == var2) ? true : false;
        }
        public static bool operator !=(int32_t var1, double var2)       /* != */
        {
            return (var1.var != var2) ? true : false;
        }
        #endregion
        #endregion
        #endregion

        #region specials
        public override bool Equals(object obj)
        {
            return (obj is int32_t) ? this == (int32_t)obj : false;
        }
        public override int GetHashCode()
        {
            return var;
        }
        public override string ToString()
        {
            return var.ToString();
        }

        public int32_t Increment()
        {
            this.var++;
            return this;
        }
        public int32_t Decrement()
        {
            this.var--;
            return this;
        }
        #endregion
    }

    /****************************** uint32_t **********************************/
    class uint32_t
    {
        public uint var = 0;

        #region Constructors
        public uint32_t()               { var = 0; }
        public uint32_t(byte value)     { var = (uint)value; }
        public uint32_t(sbyte value)    { var = (uint)value; }
        public uint32_t(short value)    { var = (uint)value; }
        public uint32_t(ushort value)   { var = (uint)value; }
        public uint32_t(int value)      { var = (uint)value; }
        public uint32_t(uint value)     { var = value; }
        public uint32_t(long value)     { var = (uint)value; }
        public uint32_t(ulong value)    { var = (uint)value; }
        public uint32_t(float value)    { var = System.Convert.ToUInt32(System.Math.Truncate(value)); }
        public uint32_t(double value)   { var = System.Convert.ToUInt32(System.Math.Truncate(value)); }
        public uint32_t(int8_t value)   { var = (uint)value.var; }
        public uint32_t(uint8_t value)  { var = (uint)value.var; }
        public uint32_t(int16_t value)  { var = (uint)value.var; }
        public uint32_t(uint16_t value) { var = (uint)value.var; }
        public uint32_t(int32_t value)  { var = (uint)value.var; }
        public uint32_t(uint32_t value) { var = value.var; }
        public uint32_t(int64_t value)  { var = (uint)value.var; }
        public uint32_t(uint64_t value) { var = (uint)value.var; }
        #endregion

        #region types
        #region new types
        #region int8_t
        /* Assignment */
        public static implicit operator uint32_t(int8_t obj)
        {
            return new uint32_t(obj);
        }

        /* Math */
        public static uint32_t operator +(uint32_t var1, int8_t var2)   /* + */
        {
            return new uint32_t(var1.var + var2.var);
        }
        public static uint32_t operator -(uint32_t var1, int8_t var2)   /* - */
        {
            return new uint32_t(var1.var - var2.var);
        }
        public static uint32_t operator *(uint32_t var1, int8_t var2)   /* * */
        {
            return new uint32_t(var1.var * var2.var);
        }
        public static uint32_t operator /(uint32_t var1, int8_t var2)   /* / */
        {
            return new uint32_t(var1.var / var2.var);
        }
        public static uint32_t operator %(uint32_t var1, int8_t var2)   /* % */
        {
            return new uint32_t(var1.var % var2.var);
        }
        public static uint32_t operator &(uint32_t var1, int8_t var2)   /* & */
        {
            return new uint32_t(var1.var & var2.var);
        }
        public static uint32_t operator |(uint32_t var1, int8_t var2)   /* | */
        {
            return new uint32_t(var1.var | (byte)var2.var);
        }
        public static uint32_t operator ^(uint32_t var1, int8_t var2)   /* ^ */
        {
            return new uint32_t(var1.var ^ var2.var);
        }

        /* Comparison */
        public static bool operator >(uint32_t var1, int8_t var2)       /* > */
        {
            return (var1.var > var2.var) ? true : false;
        }
        public static bool operator <(uint32_t var1, int8_t var2)       /* < */
        {
            return (var1.var < var2.var) ? true : false;
        }
        public static bool operator <=(uint32_t var1, int8_t var2)      /* <= */
        {
            return (var1.var <= var2.var) ? true : false;
        }
        public static bool operator >=(uint32_t var1, int8_t var2)      /* >= */
        {
            return (var1.var >= var2.var) ? true : false;
        }
        public static bool operator ==(uint32_t var1, int8_t var2)      /* == */
        {
            return (var1.var == var2.var) ? true : false;
        }
        public static bool operator !=(uint32_t var1, int8_t var2)      /* != */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region uint8_t
        /* Assignment */
        public static implicit operator uint32_t(uint8_t obj)
        {
            return new uint32_t(obj);
        }

        /* Math */
        public static uint32_t operator +(uint32_t var1, uint8_t var2)  /* + */
        {
            return new uint32_t(var1.var + var2.var);
        }
        public static uint32_t operator -(uint32_t var1, uint8_t var2)  /* - */
        {
            return new uint32_t(var1.var - var2.var);
        }
        public static uint32_t operator *(uint32_t var1, uint8_t var2)  /* * */
        {
            return new uint32_t(var1.var * var2.var);
        }
        public static uint32_t operator /(uint32_t var1, uint8_t var2)  /* / */
        {
            return new uint32_t(var1.var / var2.var);
        }
        public static uint32_t operator %(uint32_t var1, uint8_t var2)  /* % */
        {
            return new uint32_t(var1.var % var2.var);
        }
        public static uint32_t operator &(uint32_t var1, uint8_t var2)  /* & */
        {
            return new uint32_t(var1.var & var2.var);
        }
        public static uint32_t operator |(uint32_t var1, uint8_t var2)  /* | */
        {
            return new uint32_t(var1.var | var2.var);
        }
        public static uint32_t operator ^(uint32_t var1, uint8_t var2)  /* ^ */
        {
            return new uint32_t(var1.var ^ var2.var);
        }

        /* Comparison */
        public static bool operator >(uint32_t var1, uint8_t var2)      /* > */
        {
            return (var1.var > var2.var) ? true : false;
        }
        public static bool operator <(uint32_t var1, uint8_t var2)      /* < */
        {
            return (var1.var < var2.var) ? true : false;
        }
        public static bool operator <=(uint32_t var1, uint8_t var2)     /* <= */
        {
            return (var1.var <= var2.var) ? true : false;
        }
        public static bool operator >=(uint32_t var1, uint8_t var2)     /* >= */
        {
            return (var1.var >= var2.var) ? true : false;
        }
        public static bool operator ==(uint32_t var1, uint8_t var2)     /* == */
        {
            return (var1.var == var2.var) ? true : false;
        }
        public static bool operator !=(uint32_t var1, uint8_t var2)     /* != */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region int16_t
        /* Assignment */
        public static implicit operator uint32_t(int16_t obj)
        {
            return new uint32_t(obj);
        }

        /* Math */
        public static uint32_t operator +(uint32_t var1, int16_t var2)  /* + */
        {
            return new uint32_t(var1.var + var2.var);
        }
        public static uint32_t operator -(uint32_t var1, int16_t var2)  /* - */
        {
            return new uint32_t(var1.var - var2.var);
        }
        public static uint32_t operator *(uint32_t var1, int16_t var2)  /* * */
        {
            return new uint32_t(var1.var * var2.var);
        }
        public static uint32_t operator /(uint32_t var1, int16_t var2)  /* / */
        {
            return new uint32_t(var1.var / var2.var);
        }
        public static uint32_t operator %(uint32_t var1, int16_t var2)  /* % */
        {
            return new uint32_t(var1.var % var2.var);
        }
        public static uint32_t operator &(uint32_t var1, int16_t var2)  /* & */
        {
            return new uint32_t(var1.var & var2.var);
        }
        public static uint32_t operator |(uint32_t var1, int16_t var2)  /* | */
        {
            return new uint32_t(var1.var | (ushort)var2.var);
        }
        public static uint32_t operator ^(uint32_t var1, int16_t var2)  /* ^ */
        {
            return new uint32_t(var1.var ^ var2.var);
        }

        /* Comparison */
        public static bool operator >(uint32_t var1, int16_t var2)      /* > */
        {
            return (var1.var > var2.var) ? true : false;
        }
        public static bool operator <(uint32_t var1, int16_t var2)      /* < */
        {
            return (var1.var < var2.var) ? true : false;
        }
        public static bool operator <=(uint32_t var1, int16_t var2)     /* <= */
        {
            return (var1.var <= var2.var) ? true : false;
        }
        public static bool operator >=(uint32_t var1, int16_t var2)     /* >= */
        {
            return (var1.var >= var2.var) ? true : false;
        }
        public static bool operator ==(uint32_t var1, int16_t var2)     /* == */
        {
            return (var1.var == var2.var) ? true : false;
        }
        public static bool operator !=(uint32_t var1, int16_t var2)     /* != */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region uint16_t
        /* Assignment */
        public static implicit operator uint32_t(uint16_t obj)
        {
            return new uint32_t(obj);
        }

        /* Math */
        public static uint32_t operator +(uint32_t var1, uint16_t var2) /* + */
        {
            return new uint32_t(var1.var + var2.var);
        }
        public static uint32_t operator -(uint32_t var1, uint16_t var2) /* - */
        {
            return new uint32_t(var1.var - var2.var);
        }
        public static uint32_t operator *(uint32_t var1, uint16_t var2) /* * */
        {
            return new uint32_t(var1.var * var2.var);
        }
        public static uint32_t operator /(uint32_t var1, uint16_t var2) /* / */
        {
            return new uint32_t(var1.var / var2.var);
        }
        public static uint32_t operator %(uint32_t var1, uint16_t var2) /* % */
        {
            return new uint32_t(var1.var % var2.var);
        }
        public static uint32_t operator &(uint32_t var1, uint16_t var2) /* & */
        {
            return new uint32_t(var1.var & var2.var);
        }
        public static uint32_t operator |(uint32_t var1, uint16_t var2) /* | */
        {
            return new uint32_t(var1.var | var2.var);
        }
        public static uint32_t operator ^(uint32_t var1, uint16_t var2) /* ^ */
        {
            return new uint32_t(var1.var ^ var2.var);
        }

        /* Comparison */
        public static bool operator >(uint32_t var1, uint16_t var2)     /* > */
        {
            return (var1.var > var2.var) ? true : false;
        }
        public static bool operator <(uint32_t var1, uint16_t var2)     /* < */
        {
            return (var1.var < var2.var) ? true : false;
        }
        public static bool operator <=(uint32_t var1, uint16_t var2)    /* <= */
        {
            return (var1.var <= var2.var) ? true : false;
        }
        public static bool operator >=(uint32_t var1, uint16_t var2)    /* >= */
        {
            return (var1.var >= var2.var) ? true : false;
        }
        public static bool operator ==(uint32_t var1, uint16_t var2)    /* == */
        {
            return (var1.var == var2.var) ? true : false;
        }
        public static bool operator !=(uint32_t var1, uint16_t var2)    /* != */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region int32_t
        /* Assignment */
        public static implicit operator uint32_t(int32_t obj)
        {
            return new uint32_t(obj);
        }

        /* Math */
        public static uint32_t operator +(uint32_t var1, int32_t var2)  /* + */
        {
            return new uint32_t(var1.var + var2.var);
        }
        public static uint32_t operator -(uint32_t var1, int32_t var2)  /* - */
        {
            return new uint32_t(var1.var - var2.var);
        }
        public static uint32_t operator *(uint32_t var1, int32_t var2)  /* * */
        {
            return new uint32_t(var1.var * var2.var);
        }
        public static uint32_t operator /(uint32_t var1, int32_t var2)  /* / */
        {
            return new uint32_t(var1.var / var2.var);
        }
        public static uint32_t operator %(uint32_t var1, int32_t var2)  /* % */
        {
            return new uint32_t(var1.var % var2.var);
        }
        public static uint32_t operator &(uint32_t var1, int32_t var2)  /* & */
        {
            return new uint32_t(var1.var & var2.var);
        }
        public static uint32_t operator |(uint32_t var1, int32_t var2)  /* | */
        {
            return new uint32_t(var1.var | (uint)var2.var);
        }
        public static uint32_t operator ^(uint32_t var1, int32_t var2)  /* ^ */
        {
            return new uint32_t(var1.var ^ var2.var);
        }

        /* Comparison */
        public static bool operator >(uint32_t var1, int32_t var2)      /* > */
        {
            return (var1.var > var2.var) ? true : false;
        }
        public static bool operator <(uint32_t var1, int32_t var2)      /* < */
        {
            return (var1.var < var2.var) ? true : false;
        }
        public static bool operator <=(uint32_t var1, int32_t var2)     /* <= */
        {
            return (var1.var <= var2.var) ? true : false;
        }
        public static bool operator >=(uint32_t var1, int32_t var2)     /* >= */
        {
            return (var1.var >= var2.var) ? true : false;
        }
        public static bool operator ==(uint32_t var1, int32_t var2)     /* == */
        {
            return (var1.var == var2.var) ? true : false;
        }
        public static bool operator !=(uint32_t var1, int32_t var2)     /* != */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region uint32_t
        /* Unary operators */
        public static uint32_t operator ++(uint32_t obj)                /* ++ */
        {
            obj.Increment();
            return obj;
        }
        public static uint32_t operator --(uint32_t obj)                /* -- */
        {
            obj.Decrement();
            return obj;
        }
        public static uint32_t operator -(uint32_t obj)                 /* - (unary) */
        {
            return new uint32_t(-obj.var);
        }
        public static uint32_t operator +(uint32_t obj)                 /* + (unary) */
        {
            return new uint32_t(obj);
        }
        public static uint32_t operator ~(uint32_t obj)                 /* ~ */
        {
            return new uint32_t(~obj.var);
        }

        /* Math */
        public static uint32_t operator +(uint32_t var1, uint32_t var2) /* + */
        {
            return new uint32_t(var1.var + var2.var);
        }
        public static uint32_t operator -(uint32_t var1, uint32_t var2) /* - */
        {
            return new uint32_t(var1.var - var2.var);
        }
        public static uint32_t operator *(uint32_t var1, uint32_t var2) /* * */
        {
            return new uint32_t(var1.var * var2.var);
        }
        public static uint32_t operator /(uint32_t var1, uint32_t var2) /* / */
        {
            return new uint32_t(var1.var / var2.var);
        }
        public static uint32_t operator %(uint32_t var1, uint32_t var2) /* % */
        {
            return new uint32_t(var1.var % var2.var);
        }
        public static uint32_t operator &(uint32_t var1, uint32_t var2) /* & */
        {
            return new uint32_t(var1.var & var2.var);
        }
        public static uint32_t operator |(uint32_t var1, uint32_t var2) /* | */
        {
            return new uint32_t(var1.var | var2.var);
        }
        public static uint32_t operator ^(uint32_t var1, uint32_t var2) /* ^ */
        {
            return new uint32_t(var1.var ^ var2.var);
        }

        /* Comparison */
        public static bool operator >(uint32_t var1, uint32_t var2)     /* > */
        {
            return (var1.var > var2.var) ? true : false;
        }
        public static bool operator <(uint32_t var1, uint32_t var2)     /* < */
        {
            return (var1.var < var2.var) ? true : false;
        }
        public static bool operator <=(uint32_t var1, uint32_t var2)    /* <= */
        {
            return (var1.var <= var2.var) ? true : false;
        }
        public static bool operator >=(uint32_t var1, uint32_t var2)    /* >= */
        {
            return (var1.var >= var2.var) ? true : false;
        }
        public static bool operator ==(uint32_t var1, uint32_t var2)    /* == */
        {
            return (var1.var == var2.var) ? true : false;
        }
        public static bool operator !=(uint32_t var1, uint32_t var2)    /* != */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region int64_t
        /* Assignment */
        public static implicit operator uint32_t(int64_t obj)
        {
            return new uint32_t(obj);
        }

        /* Math */
        public static uint32_t operator +(uint32_t var1, int64_t var2)  /* + */
        {
            return new uint32_t(var1.var + var2.var);
        }
        public static uint32_t operator -(uint32_t var1, int64_t var2)  /* - */
        {
            return new uint32_t(var1.var - var2.var);
        }
        public static uint32_t operator *(uint32_t var1, int64_t var2)  /* * */
        {
            return new uint32_t(var1.var * var2.var);
        }
        public static uint32_t operator /(uint32_t var1, int64_t var2)  /* / */
        {
            return new uint32_t(var1.var / var2.var);
        }
        public static uint32_t operator %(uint32_t var1, int64_t var2)  /* % */
        {
            return new uint32_t(var1.var % var2.var);
        }
        public static uint32_t operator &(uint32_t var1, int64_t var2)  /* & */
        {
            return new uint32_t(var1.var & var2.var);
        }
        public static uint32_t operator |(uint32_t var1, int64_t var2)  /* | */
        {
            return new uint32_t(var1.var | var2.var);
        }
        public static uint32_t operator ^(uint32_t var1, int64_t var2)  /* ^ */
        {
            return new uint32_t(var1.var ^ var2.var);
        }

        /* Comparison */
        public static bool operator >(uint32_t var1, int64_t var2)      /* > */
        {
            return (var1.var > var2.var) ? true : false;
        }
        public static bool operator <(uint32_t var1, int64_t var2)      /* < */
        {
            return (var1.var < var2.var) ? true : false;
        }
        public static bool operator <=(uint32_t var1, int64_t var2)     /* <= */
        {
            return (var1.var <= var2.var) ? true : false;
        }
        public static bool operator >=(uint32_t var1, int64_t var2)     /* >= */
        {
            return (var1.var >= var2.var) ? true : false;
        }
        public static bool operator ==(uint32_t var1, int64_t var2)     /* == */
        {
            return (var1.var == var2.var) ? true : false;
        }
        public static bool operator !=(uint32_t var1, int64_t var2)     /* != */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region uint64_t
        /* Assignment */
        public static implicit operator uint32_t(uint64_t obj)
        {
            return new uint32_t(obj);
        }

        /* Math */
        public static uint32_t operator +(uint32_t var1, uint64_t var2) /* + */
        {
            return new uint32_t(var1.var + var2.var);
        }
        public static uint32_t operator -(uint32_t var1, uint64_t var2) /* - */
        {
            return new uint32_t(var1.var - var2.var);
        }
        public static uint32_t operator *(uint32_t var1, uint64_t var2) /* * */
        {
            return new uint32_t(var1.var * var2.var);
        }
        public static uint32_t operator /(uint32_t var1, uint64_t var2) /* / */
        {
            return new uint32_t(var1.var / var2.var);
        }
        public static uint32_t operator %(uint32_t var1, uint64_t var2) /* % */
        {
            return new uint32_t(var1.var % var2.var);
        }
        public static uint32_t operator &(uint32_t var1, uint64_t var2) /* & */
        {
            return new uint32_t(var1.var & var2.var);
        }
        public static uint32_t operator |(uint32_t var1, uint64_t var2) /* | */
        {
            return new uint32_t(var1.var | var2.var);
        }
        public static uint32_t operator ^(uint32_t var1, uint64_t var2) /* ^ */
        {
            return new uint32_t(var1.var ^ var2.var);
        }

        /* Comparison */
        public static bool operator >(uint32_t var1, uint64_t var2)     /* > */
        {
            return (var1.var > var2.var) ? true : false;
        }
        public static bool operator <(uint32_t var1, uint64_t var2)     /* < */
        {
            return (var1.var < var2.var) ? true : false;
        }
        public static bool operator <=(uint32_t var1, uint64_t var2)    /* <= */
        {
            return (var1.var <= var2.var) ? true : false;
        }
        public static bool operator >=(uint32_t var1, uint64_t var2)    /* >= */
        {
            return (var1.var >= var2.var) ? true : false;
        }
        public static bool operator ==(uint32_t var1, uint64_t var2)    /* == */
        {
            return (var1.var == var2.var) ? true : false;
        }
        public static bool operator !=(uint32_t var1, uint64_t var2)    /* != */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #endregion

        #region default types
        #region sbyte
        /* Assignment */
        public static implicit operator sbyte(uint32_t obj)
        {
            return (sbyte)obj.var;
        }

        public static implicit operator uint32_t(sbyte var)
        {
            return new uint32_t(var);
        }

        /* Math */
        public static uint32_t operator +(uint32_t var1, sbyte var2)    /* + */
        {
            return new uint32_t(var1.var + var2);
        }
        public static uint32_t operator -(uint32_t var1, sbyte var2)    /* - */
        {
            return new uint32_t(var1.var - var2);
        }
        public static uint32_t operator *(uint32_t var1, sbyte var2)    /* * */
        {
            return new uint32_t(var1.var * var2);
        }
        public static uint32_t operator /(uint32_t var1, sbyte var2)    /* / */
        {
            return new uint32_t(var1.var / var2);
        }
        public static uint32_t operator %(uint32_t var1, sbyte var2)    /* % */
        {
            return new uint32_t(var1.var % var2);
        }
        public static uint32_t operator &(uint32_t var1, sbyte var2)    /* & */
        {
            return new uint32_t(var1.var & var2);
        }
        public static uint32_t operator |(uint32_t var1, sbyte var2)    /* | */
        {
            return new uint32_t(var1.var | (byte)var2);
        }
        public static uint32_t operator ^(uint32_t var1, sbyte var2)    /* != */
        {
            return new uint32_t(var1.var ^ var2);
        }

        /* Comparison */
        public static bool operator >(uint32_t var1, sbyte var2)        /* > */
        {
            return (var1.var > var2) ? true : false;
        }
        public static bool operator <(uint32_t var1, sbyte var2)        /* < */
        {
            return (var1.var < var2) ? true : false;
        }
        public static bool operator <=(uint32_t var1, sbyte var2)       /* <= */
        {
            return (var1.var <= var2) ? true : false;
        }
        public static bool operator >=(uint32_t var1, sbyte var2)       /* >= */
        {
            return (var1.var >= var2) ? true : false;
        }
        public static bool operator ==(uint32_t var1, sbyte var2)       /* == */
        {
            return (var1.var == var2) ? true : false;
        }
        public static bool operator !=(uint32_t var1, sbyte var2)       /* != */
        {
            return (var1.var != var2) ? true : false;
        }
        #endregion
        #region byte
        /* Assignment */
        public static implicit operator byte(uint32_t obj)
        {
            return (byte)obj.var;
        }

        public static implicit operator uint32_t(byte var)
        {
            return new uint32_t(var);
        }

        /* Math */
        public static uint32_t operator +(uint32_t var1, byte var2)     /* + */
        {
            return new uint32_t(var1.var + var2);
        }
        public static uint32_t operator -(uint32_t var1, byte var2)     /* - */
        {
            return new uint32_t(var1.var - var2);
        }
        public static uint32_t operator *(uint32_t var1, byte var2)     /* * */
        {
            return new uint32_t(var1.var * var2);
        }
        public static uint32_t operator /(uint32_t var1, byte var2)     /* / */
        {
            return new uint32_t(var1.var / var2);
        }
        public static uint32_t operator %(uint32_t var1, byte var2)     /* % */
        {
            return new uint32_t(var1.var % var2);
        }
        public static uint32_t operator &(uint32_t var1, byte var2)     /* & */
        {
            return new uint32_t(var1.var & var2);
        }
        public static uint32_t operator |(uint32_t var1, byte var2)     /* | */
        {
            return new uint32_t(var1.var | var2);
        }
        public static uint32_t operator ^(uint32_t var1, byte var2)     /* != */
        {
            return new uint32_t(var1.var ^ var2);
        }

        /* Comparison */
        public static bool operator >(uint32_t var1, byte var2)         /* > */
        {
            return (var1.var > var2) ? true : false;
        }
        public static bool operator <(uint32_t var1, byte var2)         /* < */
        {
            return (var1.var < var2) ? true : false;
        }
        public static bool operator <=(uint32_t var1, byte var2)        /* <= */
        {
            return (var1.var <= var2) ? true : false;
        }
        public static bool operator >=(uint32_t var1, byte var2)        /* >= */
        {
            return (var1.var >= var2) ? true : false;
        }
        public static bool operator ==(uint32_t var1, byte var2)        /* == */
        {
            return (var1.var == var2) ? true : false;
        }
        public static bool operator !=(uint32_t var1, byte var2)        /* != */
        {
            return (var1.var != var2) ? true : false;
        }
        #endregion
        #region short
        /* Assignment */
        public static implicit operator short(uint32_t obj)
        {
            return (short)obj.var;
        }

        public static implicit operator uint32_t(short var)
        {
            return new uint32_t(var);
        }

        /* Math */
        public static uint32_t operator +(uint32_t var1, short var2)    /* + */
        {
            return new uint32_t(var1.var + var2);
        }
        public static uint32_t operator -(uint32_t var1, short var2)    /* - */
        {
            return new uint32_t(var1.var - var2);
        }
        public static uint32_t operator *(uint32_t var1, short var2)    /* * */
        {
            return new uint32_t(var1.var * var2);
        }
        public static uint32_t operator /(uint32_t var1, short var2)    /* / */
        {
            return new uint32_t(var1.var / var2);
        }
        public static uint32_t operator %(uint32_t var1, short var2)    /* % */
        {
            return new uint32_t(var1.var % var2);
        }
        public static uint32_t operator &(uint32_t var1, short var2)    /* & */
        {
            return new uint32_t(var1.var & var2);
        }
        public static uint32_t operator |(uint32_t var1, short var2)    /* | */
        {
            return new uint32_t(var1.var | (ushort)var2);
        }
        public static uint32_t operator ^(uint32_t var1, short var2)    /* != */
        {
            return new uint32_t(var1.var ^ var2);
        }

        /* Comparison */
        public static bool operator >(uint32_t var1, short var2)        /* > */
        {
            return (var1.var > var2) ? true : false;
        }
        public static bool operator <(uint32_t var1, short var2)        /* < */
        {
            return (var1.var < var2) ? true : false;
        }
        public static bool operator <=(uint32_t var1, short var2)       /* <= */
        {
            return (var1.var <= var2) ? true : false;
        }
        public static bool operator >=(uint32_t var1, short var2)       /* >= */
        {
            return (var1.var >= var2) ? true : false;
        }
        public static bool operator ==(uint32_t var1, short var2)       /* == */
        {
            return (var1.var == var2) ? true : false;
        }
        public static bool operator !=(uint32_t var1, short var2)       /* != */
        {
            return (var1.var != var2) ? true : false;
        }
        #endregion
        #region ushort
        /* Assignment */
        public static implicit operator ushort(uint32_t obj)
        {
            return (ushort)obj.var;
        }

        public static implicit operator uint32_t(ushort var)
        {
            return new uint32_t(var);
        }

        /* Math */
        public static uint32_t operator +(uint32_t var1, ushort var2)   /* + */
        {
            return new uint32_t(var1.var + var2);
        }
        public static uint32_t operator -(uint32_t var1, ushort var2)   /* - */
        {
            return new uint32_t(var1.var - var2);
        }
        public static uint32_t operator *(uint32_t var1, ushort var2)   /* * */
        {
            return new uint32_t(var1.var * var2);
        }
        public static uint32_t operator /(uint32_t var1, ushort var2)   /* / */
        {
            return new uint32_t(var1.var / var2);
        }
        public static uint32_t operator %(uint32_t var1, ushort var2)   /* % */
        {
            return new uint32_t(var1.var % var2);
        }
        public static uint32_t operator &(uint32_t var1, ushort var2)   /* & */
        {
            return new uint32_t(var1.var & var2);
        }
        public static uint32_t operator |(uint32_t var1, ushort var2)   /* | */
        {
            return new uint32_t(var1.var | var2);
        }
        public static uint32_t operator ^(uint32_t var1, ushort var2)   /* != */
        {
            return new uint32_t(var1.var ^ var2);
        }

        /* Comparison */
        public static bool operator >(uint32_t var1, ushort var2)       /* > */
        {
            return (var1.var > var2) ? true : false;
        }
        public static bool operator <(uint32_t var1, ushort var2)       /* < */
        {
            return (var1.var < var2) ? true : false;
        }
        public static bool operator <=(uint32_t var1, ushort var2)      /* <= */
        {
            return (var1.var <= var2) ? true : false;
        }
        public static bool operator >=(uint32_t var1, ushort var2)      /* >= */
        {
            return (var1.var >= var2) ? true : false;
        }
        public static bool operator ==(uint32_t var1, ushort var2)      /* == */
        {
            return (var1.var == var2) ? true : false;
        }
        public static bool operator !=(uint32_t var1, ushort var2)      /* != */
        {
            return (var1.var != var2) ? true : false;
        }
        #endregion
        #region int
        /* Assignment */
        public static implicit operator int(uint32_t obj)
        {
            return (int)obj.var;
        }

        public static implicit operator uint32_t(int var)
        {
            return new uint32_t(var);
        }

        /* Math */
        public static uint32_t operator +(uint32_t var1, int var2)      /* + */
        {
            return new uint32_t(var1.var + var2);
        }
        public static uint32_t operator -(uint32_t var1, int var2)      /* - */
        {
            return new uint32_t(var1.var - var2);
        }
        public static uint32_t operator *(uint32_t var1, int var2)      /* * */
        {
            return new uint32_t(var1.var * var2);
        }
        public static uint32_t operator /(uint32_t var1, int var2)      /* / */
        {
            return new uint32_t(var1.var / var2);
        }
        public static uint32_t operator %(uint32_t var1, int var2)      /* % */
        {
            return new uint32_t(var1.var % var2);
        }
        public static uint32_t operator &(uint32_t var1, int var2)      /* & */
        {
            return new uint32_t(var1.var & var2);
        }
        public static uint32_t operator |(uint32_t var1, int var2)      /* | */
        {
            return new uint32_t(var1.var | (uint)var2);
        }
        public static uint32_t operator ^(uint32_t var1, int var2)      /* ^ */
        {
            return new uint32_t(var1.var ^ var2);
        }
        public static uint32_t operator >>(uint32_t var1, int var2)     /* >> */
        {
            return new uint32_t(var1.var >> var2);
        }
        public static uint32_t operator <<(uint32_t var1, int var2)     /* << */
        {
            return new uint32_t(var1.var << var2);
        }

        /* Comparison */
        public static bool operator >(uint32_t var1, int var2)          /* > */
        {
            return (var1.var > var2) ? true : false;
        }
        public static bool operator <(uint32_t var1, int var2)          /* < */
        {
            return (var1.var < var2) ? true : false;
        }
        public static bool operator <=(uint32_t var1, int var2)         /* <= */
        {
            return (var1.var <= var2) ? true : false;
        }
        public static bool operator >=(uint32_t var1, int var2)         /* >= */
        {
            return (var1.var >= var2) ? true : false;
        }
        public static bool operator ==(uint32_t var1, int var2)         /* == */
        {
            return (var1.var == var2) ? true : false;
        }
        public static bool operator !=(uint32_t var1, int var2)         /* != */
        {
            return (var1.var != var2) ? true : false;
        }
        #endregion
        #region uint
        /* Assignment */
        public static implicit operator uint(uint32_t obj)
        {
            return obj.var;
        }

        public static implicit operator uint32_t(uint var)
        {
            return new uint32_t(var);
        }

        /* Math */
        public static uint32_t operator +(uint32_t var1, uint var2)     /* + */
        {
            return new uint32_t(var1.var + var2);
        }
        public static uint32_t operator -(uint32_t var1, uint var2)     /* - */
        {
            return new uint32_t(var1.var - var2);
        }
        public static uint32_t operator *(uint32_t var1, uint var2)     /* * */
        {
            return new uint32_t(var1.var * var2);
        }
        public static uint32_t operator /(uint32_t var1, uint var2)     /* / */
        {
            return new uint32_t(var1.var / var2);
        }
        public static uint32_t operator %(uint32_t var1, uint var2)     /* % */
        {
            return new uint32_t(var1.var % var2);
        }
        public static uint32_t operator &(uint32_t var1, uint var2)     /* & */
        {
            return new uint32_t(var1.var & var2);
        }
        public static uint32_t operator |(uint32_t var1, uint var2)     /* | */
        {
            return new uint32_t(var1.var | var2);
        }
        public static uint32_t operator ^(uint32_t var1, uint var2)     /* != */
        {
            return new uint32_t(var1.var ^ var2);
        }

        /* Comparison */
        public static bool operator >(uint32_t var1, uint var2)         /* > */
        {
            return (var1.var > var2) ? true : false;
        }
        public static bool operator <(uint32_t var1, uint var2)         /* < */
        {
            return (var1.var < var2) ? true : false;
        }
        public static bool operator <=(uint32_t var1, uint var2)        /* <= */
        {
            return (var1.var <= var2) ? true : false;
        }
        public static bool operator >=(uint32_t var1, uint var2)        /* >= */
        {
            return (var1.var >= var2) ? true : false;
        }
        public static bool operator ==(uint32_t var1, uint var2)        /* == */
        {
            return (var1.var == var2) ? true : false;
        }
        public static bool operator !=(uint32_t var1, uint var2)        /* != */
        {
            return (var1.var != var2) ? true : false;
        }
        #endregion
        #region long
        /* Assignment */
        public static implicit operator long(uint32_t obj)
        {
            return (long)obj.var;
        }

        public static implicit operator uint32_t(long var)
        {
            return new uint32_t(var);
        }

        /* Math */
        public static uint32_t operator +(uint32_t var1, long var2)     /* + */
        {
            return new uint32_t(var1.var + var2);
        }
        public static uint32_t operator -(uint32_t var1, long var2)     /* - */
        {
            return new uint32_t(var1.var - var2);
        }
        public static uint32_t operator *(uint32_t var1, long var2)     /* * */
        {
            return new uint32_t(var1.var * var2);
        }
        public static uint32_t operator /(uint32_t var1, long var2)     /* / */
        {
            return new uint32_t(var1.var / var2);
        }
        public static uint32_t operator %(uint32_t var1, long var2)     /* % */
        {
            return new uint32_t(var1.var % var2);
        }
        public static uint32_t operator &(uint32_t var1, long var2)     /* & */
        {
            return new uint32_t(var1.var & var2);
        }
        public static uint32_t operator |(uint32_t var1, long var2)     /* | */
        {
            return new uint32_t(var1.var | var2);
        }
        public static uint32_t operator ^(uint32_t var1, long var2)     /* != */
        {
            return new uint32_t(var1.var ^ var2);
        }

        /* Comparison */
        public static bool operator >(uint32_t var1, long var2)         /* > */
        {
            return (var1.var > var2) ? true : false;
        }
        public static bool operator <(uint32_t var1, long var2)         /* < */
        {
            return (var1.var < var2) ? true : false;
        }
        public static bool operator <=(uint32_t var1, long var2)        /* <= */
        {
            return (var1.var <= var2) ? true : false;
        }
        public static bool operator >=(uint32_t var1, long var2)        /* >= */
        {
            return (var1.var >= var2) ? true : false;
        }
        public static bool operator ==(uint32_t var1, long var2)        /* == */
        {
            return (var1.var == var2) ? true : false;
        }
        public static bool operator !=(uint32_t var1, long var2)        /* != */
        {
            return (var1.var != var2) ? true : false;
        }
        #endregion
        #region ulong
        /* Assignment */
        public static implicit operator ulong(uint32_t obj)
        {
            return (ulong)obj.var;
        }

        public static implicit operator uint32_t(ulong var)
        {
            return new uint32_t(var);
        }

        /* Math */
        public static uint32_t operator +(uint32_t var1, ulong var2)    /* + */
        {
            return new uint32_t(var1.var + var2);
        }
        public static uint32_t operator -(uint32_t var1, ulong var2)    /* - */
        {
            return new uint32_t(var1.var - var2);
        }
        public static uint32_t operator *(uint32_t var1, ulong var2)    /* * */
        {
            return new uint32_t(var1.var * var2);
        }
        public static uint32_t operator /(uint32_t var1, ulong var2)    /* / */
        {
            return new uint32_t(var1.var / var2);
        }
        public static uint32_t operator %(uint32_t var1, ulong var2)    /* % */
        {
            return new uint32_t(var1.var % var2);
        }
        public static uint32_t operator &(uint32_t var1, ulong var2)    /* & */
        {
            return new uint32_t(var1.var & var2);
        }
        public static uint32_t operator |(uint32_t var1, ulong var2)    /* | */
        {
            return new uint32_t(var1.var | var2);
        }
        public static uint32_t operator ^(uint32_t var1, ulong var2)    /* != */
        {
            return new uint32_t(var1.var ^ var2);
        }

        /* Comparison */
        public static bool operator >(uint32_t var1, ulong var2)        /* > */
        {
            return (var1.var > var2) ? true : false;
        }
        public static bool operator <(uint32_t var1, ulong var2)        /* < */
        {
            return (var1.var < var2) ? true : false;
        }
        public static bool operator <=(uint32_t var1, ulong var2)       /* <= */
        {
            return (var1.var <= var2) ? true : false;
        }
        public static bool operator >=(uint32_t var1, ulong var2)       /* >= */
        {
            return (var1.var >= var2) ? true : false;
        }
        public static bool operator ==(uint32_t var1, ulong var2)       /* == */
        {
            return (var1.var == var2) ? true : false;
        }
        public static bool operator !=(uint32_t var1, ulong var2)       /* != */
        {
            return (var1.var != var2) ? true : false;
        }
        #endregion

        #region float
        /* Math */
        public static uint32_t operator +(uint32_t var1, float var2)    /* + */
        {
            return new uint32_t(var1.var + var2);
        }
        public static uint32_t operator -(uint32_t var1, float var2)    /* - */
        {
            return new uint32_t(var1.var - var2);
        }
        public static uint32_t operator *(uint32_t var1, float var2)    /* * */
        {
            return new uint32_t(var1.var * var2);
        }
        public static uint32_t operator /(uint32_t var1, float var2)    /* / */
        {
            return new uint32_t(var1.var / var2);
        }
        public static uint32_t operator %(uint32_t var1, float var2)    /* % */
        {
            return new uint32_t(var1.var % var2);
        }
        public static uint32_t operator &(uint32_t var1, float var2)    /* & */
        {
            throw new System.ArgumentException(System.String.Format("& operator cannot be applied with float parameter {0}", var2));
        }
        public static uint32_t operator |(uint32_t var1, float var2)    /* | */
        {
            throw new System.ArgumentException(System.String.Format("| operator cannot be applied with float parameter {0}", var2));
        }
        public static uint32_t operator ^(uint32_t var1, float var2)    /* != */
        {
            throw new System.ArgumentException(System.String.Format("^ operator cannot be applied with float parameter {0}", var2));
        }

        /* Comparison */
        public static bool operator >(uint32_t var1, float var2)        /* > */
        {
            return (var1.var > var2) ? true : false;
        }
        public static bool operator <(uint32_t var1, float var2)        /* < */
        {
            return (var1.var < var2) ? true : false;
        }
        public static bool operator <=(uint32_t var1, float var2)       /* <= */
        {
            return (var1.var <= var2) ? true : false;
        }
        public static bool operator >=(uint32_t var1, float var2)       /* >= */
        {
            return (var1.var >= var2) ? true : false;
        }
        public static bool operator ==(uint32_t var1, float var2)       /* == */
        {
            return (var1.var == var2) ? true : false;
        }
        public static bool operator !=(uint32_t var1, float var2)       /* != */
        {
            return (var1.var != var2) ? true : false;
        }
        #endregion
        #region double
        /* Math */
        public static uint32_t operator +(uint32_t var1, double var2)   /* + */
        {
            return new uint32_t(var1.var + var2);
        }
        public static uint32_t operator -(uint32_t var1, double var2)   /* - */
        {
            return new uint32_t(var1.var - var2);
        }
        public static uint32_t operator *(uint32_t var1, double var2)   /* * */
        {
            return new uint32_t(var1.var * var2);
        }
        public static uint32_t operator /(uint32_t var1, double var2)   /* / */
        {
            return new uint32_t(var1.var / var2);
        }
        public static uint32_t operator %(uint32_t var1, double var2)   /* % */
        {
            return new uint32_t(var1.var % var2);
        }
        public static uint32_t operator &(uint32_t var1, double var2)   /* & */
        {
            throw new System.ArgumentException(System.String.Format("& operator cannot be applied with double parameter {0}", var2));
        }
        public static uint32_t operator |(uint32_t var1, double var2)   /* | */
        {
            throw new System.ArgumentException(System.String.Format("| operator cannot be applied with double parameter {0}", var2));
        }
        public static uint32_t operator ^(uint32_t var1, double var2)   /* != */
        {
            throw new System.ArgumentException(System.String.Format("^ operator cannot be applied with double parameter {0}", var2));
        }

        /* Comparison */
        public static bool operator >(uint32_t var1, double var2)       /* > */
        {
            return (var1.var > var2) ? true : false;
        }
        public static bool operator <(uint32_t var1, double var2)       /* < */
        {
            return (var1.var < var2) ? true : false;
        }
        public static bool operator <=(uint32_t var1, double var2)      /* <= */
        {
            return (var1.var <= var2) ? true : false;
        }
        public static bool operator >=(uint32_t var1, double var2)      /* >= */
        {
            return (var1.var >= var2) ? true : false;
        }
        public static bool operator ==(uint32_t var1, double var2)      /* == */
        {
            return (var1.var == var2) ? true : false;
        }
        public static bool operator !=(uint32_t var1, double var2)      /* != */
        {
            return (var1.var != var2) ? true : false;
        }
        #endregion
        #endregion
        #endregion

        #region specials
        public override bool Equals(object obj)
        {
            return (obj is uint32_t) ? this == (uint32_t)obj : false;
        }
        public override string ToString()
        {
            return var.ToString();
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public uint32_t Increment()
        {
            this.var++;
            return this;
        }
        public uint32_t Decrement()
        {
            this.var--;
            return this;
        }
        #endregion
    }

    /****************************** int64_t **********************************/
    class int64_t
    {
        public long var = 0;

        #region Constructors
        public int64_t()                { var = 0; }
        public int64_t(byte value)      { var = (long)value; }
        public int64_t(sbyte value)     { var = (long)value; }
        public int64_t(short value)     { var = (long)value; }
        public int64_t(ushort value)    { var = (long)value; }
        public int64_t(int value)       { var = (long)value; }
        public int64_t(uint value)      { var = (long)value; }
        public int64_t(long value)      { var = value; }
        public int64_t(ulong value)     { var = (long)value; }
        public int64_t(float value)     { var = System.Convert.ToInt64(System.Math.Truncate(value)); }
        public int64_t(double value)    { var = System.Convert.ToInt64(System.Math.Truncate(value)); }
        public int64_t(int8_t value)    { var = (long)value.var; }
        public int64_t(uint8_t value)   { var = (long)value.var; }
        public int64_t(int16_t value)   { var = (long)value.var; }
        public int64_t(uint16_t value)  { var = (long)value.var; }
        public int64_t(int32_t value)   { var = (long)value.var; }
        public int64_t(uint32_t value)  { var = (long)value.var; }
        public int64_t(int64_t value)   { var = value.var; }
        public int64_t(uint64_t value)  { var = (long)value.var; }
        #endregion

        #region types
        #region new types
        #region int8_t
        /* Assignment */
        public static implicit operator int64_t(int8_t obj)
        {
            return new int64_t(obj);
        }

        /* Math */
        public static int64_t operator +(int64_t var1, int8_t var2)     /* + */
        {                                                               
            return new int64_t(var1.var + var2.var);                    
        }                                                               
        public static int64_t operator -(int64_t var1, int8_t var2)     /* - */
        {                                                               
            return new int64_t(var1.var - var2.var);                    
        }                                                               
        public static int64_t operator *(int64_t var1, int8_t var2)     /* * */
        {                                                               
            return new int64_t(var1.var * var2.var);                    
        }                                                               
        public static int64_t operator /(int64_t var1, int8_t var2)     /* / */
        {                                                               
            return new int64_t(var1.var / var2.var);                    
        }                                                               
        public static int64_t operator %(int64_t var1, int8_t var2)     /* % */
        {                                                               
            return new int64_t(var1.var % var2.var);                    
        }                                                               
        public static int64_t operator &(int64_t var1, int8_t var2)     /* & */
        {                                                               
            return new int64_t(var1.var & var2.var);                    
        }                                                               
        public static int64_t operator |(int64_t var1, int8_t var2)     /* | */
        {                                                               
            return new int64_t(var1.var | (byte)var2.var);                    
        }                                                               
        public static int64_t operator ^(int64_t var1, int8_t var2)     /* ^ */
        {
            return new int64_t(var1.var ^ var2.var);
        }

        /* Comparison */
        public static bool operator >(int64_t var1, int8_t var2)        /* > */
        {                                                               
            return (var1.var > var2.var) ? true : false;                
        }                                                               
        public static bool operator <(int64_t var1, int8_t var2)        /* < */
        {                                                               
            return (var1.var < var2.var) ? true : false;                
        }                                                               
        public static bool operator <=(int64_t var1, int8_t var2)       /* <= */
        {                                                               
            return (var1.var <= var2.var) ? true : false;               
        }                                                               
        public static bool operator >=(int64_t var1, int8_t var2)       /* >= */
        {                                                               
            return (var1.var >= var2.var) ? true : false;               
        }                                                               
        public static bool operator ==(int64_t var1, int8_t var2)       /* == */
        {                                                               
            return (var1.var == var2.var) ? true : false;               
        }                                                               
        public static bool operator !=(int64_t var1, int8_t var2)       /* != */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region uint8_t
        /* Assignment */
        public static implicit operator int64_t(uint8_t obj)
        {
            return new int64_t(obj);
        }

        /* Math */
        public static int64_t operator +(int64_t var1, uint8_t var2)    /* + */
        {
            return new int64_t(var1.var + var2.var);
        }
        public static int64_t operator -(int64_t var1, uint8_t var2)    /* - */
        {
            return new int64_t(var1.var - var2.var);
        }
        public static int64_t operator *(int64_t var1, uint8_t var2)    /* * */
        {
            return new int64_t(var1.var * var2.var);
        }
        public static int64_t operator /(int64_t var1, uint8_t var2)    /* / */
        {
            return new int64_t(var1.var / var2.var);
        }
        public static int64_t operator %(int64_t var1, uint8_t var2)    /* % */
        {
            return new int64_t(var1.var % var2.var);
        }
        public static int64_t operator &(int64_t var1, uint8_t var2)    /* & */
        {
            return new int64_t(var1.var & var2.var);
        }
        public static int64_t operator |(int64_t var1, uint8_t var2)    /* | */
        {
            return new int64_t(var1.var | var2.var);
        }
        public static int64_t operator ^(int64_t var1, uint8_t var2)    /* ^ */
        {
            return new int64_t(var1.var ^ var2.var);
        }

        /* Comparison */
        public static bool operator >(int64_t var1, uint8_t var2)       /* > */
        {
            return (var1.var > var2.var) ? true : false;
        }
        public static bool operator <(int64_t var1, uint8_t var2)       /* < */
        {
            return (var1.var < var2.var) ? true : false;
        }
        public static bool operator <=(int64_t var1, uint8_t var2)      /* <= */
        {
            return (var1.var <= var2.var) ? true : false;
        }
        public static bool operator >=(int64_t var1, uint8_t var2)      /* >= */
        {
            return (var1.var >= var2.var) ? true : false;
        }
        public static bool operator ==(int64_t var1, uint8_t var2)      /* == */
        {
            return (var1.var == var2.var) ? true : false;
        }
        public static bool operator !=(int64_t var1, uint8_t var2)      /* != */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region int16_t
        /* Assignment */
        public static implicit operator int64_t(int16_t obj)
        {
            return new int64_t(obj);
        }

        /* Math */
        public static int64_t operator +(int64_t var1, int16_t var2)    /* + */
        {
            return new int64_t(var1.var + var2.var);
        }
        public static int64_t operator -(int64_t var1, int16_t var2)    /* - */
        {
            return new int64_t(var1.var - var2.var);
        }
        public static int64_t operator *(int64_t var1, int16_t var2)    /* * */
        {
            return new int64_t(var1.var * var2.var);
        }
        public static int64_t operator /(int64_t var1, int16_t var2)    /* / */
        {
            return new int64_t(var1.var / var2.var);
        }
        public static int64_t operator %(int64_t var1, int16_t var2)    /* % */
        {
            return new int64_t(var1.var % var2.var);
        }
        public static int64_t operator &(int64_t var1, int16_t var2)    /* & */
        {
            return new int64_t(var1.var & var2.var);
        }
        public static int64_t operator |(int64_t var1, int16_t var2)    /* | */
        {
            return new int64_t(var1.var | (ushort)var2.var);
        }
        public static int64_t operator ^(int64_t var1, int16_t var2)    /* ^ */
        {
            return new int64_t(var1.var ^ var2.var);
        }

        /* Comparison */
        public static bool operator >(int64_t var1, int16_t var2)       /* > */
        {                                                               
            return (var1.var > var2.var) ? true : false;                
        }                                                               
        public static bool operator <(int64_t var1, int16_t var2)       /* < */
        {                                                               
            return (var1.var < var2.var) ? true : false;                
        }                                                               
        public static bool operator <=(int64_t var1, int16_t var2)      /* <= */
        {                                                               
            return (var1.var <= var2.var) ? true : false;               
        }                                                               
        public static bool operator >=(int64_t var1, int16_t var2)      /* >= */
        {                                                               
            return (var1.var >= var2.var) ? true : false;               
        }                                                               
        public static bool operator ==(int64_t var1, int16_t var2)      /* == */
        {                                                               
            return (var1.var == var2.var) ? true : false;               
        }                                                               
        public static bool operator !=(int64_t var1, int16_t var2)      /* != */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region uint16_t
        /* Assignment */
        public static implicit operator int64_t(uint16_t obj)
        {
            return new int64_t(obj);
        }

        /* Math */
        public static int64_t operator +(int64_t var1, uint16_t var2)   /* + */
        {
            return new int64_t(var1.var + var2.var);
        }
        public static int64_t operator -(int64_t var1, uint16_t var2)   /* - */
        {
            return new int64_t(var1.var - var2.var);
        }
        public static int64_t operator *(int64_t var1, uint16_t var2)   /* * */
        {
            return new int64_t(var1.var * var2.var);
        }
        public static int64_t operator /(int64_t var1, uint16_t var2)   /* / */
        {
            return new int64_t(var1.var / var2.var);
        }
        public static int64_t operator %(int64_t var1, uint16_t var2)   /* % */
        {
            return new int64_t(var1.var % var2.var);
        }
        public static int64_t operator &(int64_t var1, uint16_t var2)   /* & */
        {
            return new int64_t(var1.var & var2.var);
        }
        public static int64_t operator |(int64_t var1, uint16_t var2)   /* | */
        {
            return new int64_t(var1.var | var2.var);
        }
        public static int64_t operator ^(int64_t var1, uint16_t var2)   /* ^ */
        {
            return new int64_t(var1.var ^ var2.var);
        }

        /* Comparison */
        public static bool operator >(int64_t var1, uint16_t var2)      /* > */
        {                                                               
            return (var1.var > var2.var) ? true : false;                
        }                                                               
        public static bool operator <(int64_t var1, uint16_t var2)      /* < */
        {                                                               
            return (var1.var < var2.var) ? true : false;                
        }                                                               
        public static bool operator <=(int64_t var1, uint16_t var2)     /* <= */
        {                                                               
            return (var1.var <= var2.var) ? true : false;               
        }                                                               
        public static bool operator >=(int64_t var1, uint16_t var2)     /* >= */
        {                                                               
            return (var1.var >= var2.var) ? true : false;               
        }                                                               
        public static bool operator ==(int64_t var1, uint16_t var2)     /* == */
        {                                                               
            return (var1.var == var2.var) ? true : false;               
        }                                                               
        public static bool operator !=(int64_t var1, uint16_t var2)     /* != */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region int32_t
        /* Assignment */
        public static implicit operator int64_t(int32_t obj)
        {
            return new int64_t(obj);
        }

        /* Math */
        public static int64_t operator +(int64_t var1, int32_t var2)    /* + */
        {
            return new int64_t(var1.var + var2.var);
        }
        public static int64_t operator -(int64_t var1, int32_t var2)    /* - */
        {
            return new int64_t(var1.var - var2.var);
        }
        public static int64_t operator *(int64_t var1, int32_t var2)    /* * */
        {
            return new int64_t(var1.var * var2.var);
        }
        public static int64_t operator /(int64_t var1, int32_t var2)    /* / */
        {
            return new int64_t(var1.var / var2.var);
        }
        public static int64_t operator %(int64_t var1, int32_t var2)    /* % */
        {
            return new int64_t(var1.var % var2.var);
        }
        public static int64_t operator &(int64_t var1, int32_t var2)    /* & */
        {
            return new int64_t(var1.var & var2.var);
        }
        public static int64_t operator |(int64_t var1, int32_t var2)    /* | */
        {
            return new int64_t(var1.var | (uint)var2.var);
        }
        public static int64_t operator ^(int64_t var1, int32_t var2)    /* ^ */
        {
            return new int64_t(var1.var ^ var2.var);
        }

        /* Comparison */
        public static bool operator >(int64_t var1, int32_t var2)       /* > */
        {                                                               
            return (var1.var > var2.var) ? true : false;                
        }                                                               
        public static bool operator <(int64_t var1, int32_t var2)       /* < */
        {                                                               
            return (var1.var < var2.var) ? true : false;                
        }                                                               
        public static bool operator <=(int64_t var1, int32_t var2)      /* <= */
        {                                                               
            return (var1.var <= var2.var) ? true : false;               
        }                                                               
        public static bool operator >=(int64_t var1, int32_t var2)      /* >= */
        {                                                               
            return (var1.var >= var2.var) ? true : false;               
        }                                                               
        public static bool operator ==(int64_t var1, int32_t var2)      /* == */
        {                                                               
            return (var1.var == var2.var) ? true : false;               
        }                                                               
        public static bool operator !=(int64_t var1, int32_t var2)      /* != */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region uint32_t
        /* Assignment */
        public static implicit operator uint32_t(int64_t obj)
        {
            return new uint32_t(obj);
        }

        public static implicit operator int64_t(uint32_t obj)
        {
            return new int64_t(obj);
        }

        /* Math */
        public static int64_t operator +(int64_t var1, uint32_t var2)   /* + */
        {
            return new int64_t(var1.var + var2.var);
        }
        public static int64_t operator -(int64_t var1, uint32_t var2)   /* - */
        {
            return new int64_t(var1.var - var2.var);
        }
        public static int64_t operator *(int64_t var1, uint32_t var2)   /* * */
        {
            return new int64_t(var1.var * var2.var);
        }
        public static int64_t operator /(int64_t var1, uint32_t var2)   /* / */
        {
            return new int64_t(var1.var / var2.var);
        }
        public static int64_t operator %(int64_t var1, uint32_t var2)   /* % */
        {
            return new int64_t(var1.var % var2.var);
        }
        public static int64_t operator &(int64_t var1, uint32_t var2)   /* & */
        {
            return new int64_t(var1.var & var2.var);
        }
        public static int64_t operator |(int64_t var1, uint32_t var2)   /* | */
        {
            return new int64_t(var1.var | var2.var);
        }
        public static int64_t operator ^(int64_t var1, uint32_t var2)   /* ^ */
        {
            return new int64_t(var1.var ^ var2.var);
        }

        /* Comparison */
        public static bool operator >(int64_t var1, uint32_t var2)      /* > */
        {                                                               
            return (var1.var > var2.var) ? true : false;                
        }                                                               
        public static bool operator <(int64_t var1, uint32_t var2)      /* < */
        {                                                               
            return (var1.var < var2.var) ? true : false;                
        }                                                               
        public static bool operator <=(int64_t var1, uint32_t var2)     /* <= */
        {                                                               
            return (var1.var <= var2.var) ? true : false;               
        }                                                               
        public static bool operator >=(int64_t var1, uint32_t var2)     /* >= */
        {                                                               
            return (var1.var >= var2.var) ? true : false;               
        }                                                               
        public static bool operator ==(int64_t var1, uint32_t var2)     /* == */
        {                                                               
            return (var1.var == var2.var) ? true : false;               
        }                                                               
        public static bool operator !=(int64_t var1, uint32_t var2)     /* != */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region int64_t
        /* Unary operators */
        public static int64_t operator ++(int64_t obj)                  /* ++ */
        {
            obj.Increment();
            return obj;
        }
        public static int64_t operator --(int64_t obj)                  /* -- */
        {
            obj.Decrement();
            return obj;
        }
        public static int64_t operator -(int64_t obj)                   /* - (unary) */
        {
            return new int64_t(-obj.var);
        }
        public static int64_t operator +(int64_t obj)                   /* + (unary) */
        {
            return new int64_t(obj);
        }
        public static int64_t operator ~(int64_t obj)                   /* ~ */
        {
            return new int64_t(~obj.var);
        }

        /* Math */
        public static int64_t operator +(int64_t var1, int64_t var2)    /* + */
        {
            return new int64_t(var1.var + var2.var);
        }
        public static int64_t operator -(int64_t var1, int64_t var2)    /* - */
        {
            return new int64_t(var1.var - var2.var);
        }
        public static int64_t operator *(int64_t var1, int64_t var2)    /* * */
        {
            return new int64_t(var1.var * var2.var);
        }
        public static int64_t operator /(int64_t var1, int64_t var2)    /* / */
        {
            return new int64_t(var1.var / var2.var);
        }
        public static int64_t operator %(int64_t var1, int64_t var2)    /* % */
        {
            return new int64_t(var1.var % var2.var);
        }
        public static int64_t operator &(int64_t var1, int64_t var2)    /* & */
        {
            return new int64_t(var1.var & var2.var);
        }
        public static int64_t operator |(int64_t var1, int64_t var2)    /* | */
        {
            return new int64_t(var1.var | var2.var);
        }
        public static int64_t operator ^(int64_t var1, int64_t var2)    /* ^ */
        {
            return new int64_t(var1.var ^ var2.var);
        }

        /* Comparison */
        public static bool operator >(int64_t var1, int64_t var2)       /* > */
        {                                                               
            return (var1.var > var2.var) ? true : false;                
        }                                                               
        public static bool operator <(int64_t var1, int64_t var2)       /* < */
        {                                                               
            return (var1.var < var2.var) ? true : false;                
        }                                                               
        public static bool operator <=(int64_t var1, int64_t var2)      /* <= */
        {                                                               
            return (var1.var <= var2.var) ? true : false;               
        }                                                               
        public static bool operator >=(int64_t var1, int64_t var2)      /* >= */
        {                                                               
            return (var1.var >= var2.var) ? true : false;               
        }                                                               
        public static bool operator ==(int64_t var1, int64_t var2)      /* == */
        {                                                               
            return (var1.var == var2.var) ? true : false;               
        }                                                               
        public static bool operator !=(int64_t var1, int64_t var2)      /* != */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region uint64_t
        /* Assignment */
        public static implicit operator int64_t(uint64_t obj)
        {
            return new int64_t(obj);
        }

        /* Math */
        public static int64_t operator +(int64_t var1, uint64_t var2)   /* + */
        {
            return new int64_t((ulong)var1.var + var2.var);
        }
        public static int64_t operator -(int64_t var1, uint64_t var2)   /* - */
        {
            return new int64_t((ulong)var1.var - var2.var);
        }
        public static int64_t operator *(int64_t var1, uint64_t var2)   /* * */
        {
            return new int64_t((ulong)var1.var * var2.var);
        }
        public static int64_t operator /(int64_t var1, uint64_t var2)   /* / */
        {
            return new int64_t((ulong)var1.var / var2.var);
        }
        public static int64_t operator %(int64_t var1, uint64_t var2)   /* % */
        {
            return new int64_t((ulong)var1.var % var2.var);
        }
        public static int64_t operator &(int64_t var1, uint64_t var2)   /* & */
        {
            return new int64_t((ulong)var1.var & var2.var);
        }
        public static int64_t operator |(int64_t var1, uint64_t var2)   /* | */
        {
            return new int64_t((ulong)var1.var | var2.var);
        }
        public static int64_t operator ^(int64_t var1, uint64_t var2)   /* ^ */
        {
            return new int64_t((ulong)var1.var ^ var2.var);
        }

        /* Comparison */
        public static bool operator >(int64_t var1, uint64_t var2)      /* > */
        {                                                               
            return (var1.var > (long)var2.var) ? true : false;         
        }                                                               
        public static bool operator <(int64_t var1, uint64_t var2)      /* < */
        {                                                               
            return (var1.var < (long)var2.var) ? true : false;         
        }                                                               
        public static bool operator <=(int64_t var1, uint64_t var2)     /* <= */
        {                                                               
            return (var1.var <= (long)var2.var) ? true : false;        
        }                                                               
        public static bool operator >=(int64_t var1, uint64_t var2)     /* >= */
        {                                                               
            return (var1.var >= (long)var2.var) ? true : false;        
        }                                                               
        public static bool operator ==(int64_t var1, uint64_t var2)     /* == */
        {                                                               
            return (var1.var == (long)var2.var) ? true : false;        
        }                                                               
        public static bool operator !=(int64_t var1, uint64_t var2)     /* != */
        {
            return (var1.var != (long)var2.var) ? true : false;
        }
        #endregion
        #endregion

        #region default types
        #region sbyte
        /* Assignment */
        public static implicit operator sbyte(int64_t obj)
        {
            return (sbyte)obj.var;
        }

        public static implicit operator int64_t(sbyte var)
        {
            return new int64_t(var);
        }

        /* Math */
        public static int64_t operator +(int64_t var1, sbyte var2)      /* + */
        {
            return new int64_t(var1.var + var2);
        }
        public static int64_t operator -(int64_t var1, sbyte var2)      /* - */
        {
            return new int64_t(var1.var - var2);
        }
        public static int64_t operator *(int64_t var1, sbyte var2)      /* * */
        {
            return new int64_t(var1.var * var2);
        }
        public static int64_t operator /(int64_t var1, sbyte var2)      /* / */
        {
            return new int64_t(var1.var / var2);
        }
        public static int64_t operator %(int64_t var1, sbyte var2)      /* % */
        {
            return new int64_t(var1.var % var2);
        }
        public static int64_t operator &(int64_t var1, sbyte var2)      /* & */
        {
            return new int64_t(var1.var & var2);
        }
        public static int64_t operator |(int64_t var1, sbyte var2)      /* | */
        {
            return new int64_t(var1.var | (byte)var2);
        }
        public static int64_t operator ^(int64_t var1, sbyte var2)      /* != */
        {
            return new int64_t(var1.var ^ var2);
        }

        /* Comparison */
        public static bool operator >(int64_t var1, sbyte var2)         /* > */
        {
            return (var1.var > var2) ? true : false;
        }
        public static bool operator <(int64_t var1, sbyte var2)         /* < */
        {
            return (var1.var < var2) ? true : false;
        }
        public static bool operator <=(int64_t var1, sbyte var2)        /* <= */
        {
            return (var1.var <= var2) ? true : false;
        }
        public static bool operator >=(int64_t var1, sbyte var2)        /* >= */
        {
            return (var1.var >= var2) ? true : false;
        }
        public static bool operator ==(int64_t var1, sbyte var2)        /* == */
        {
            return (var1.var == var2) ? true : false;
        }
        public static bool operator !=(int64_t var1, sbyte var2)        /* != */
        {
            return (var1.var != var2) ? true : false;
        }
        #endregion
        #region byte
        /* Assignment */
        public static implicit operator byte(int64_t obj)
        {
            return (byte)obj.var;
        }

        public static implicit operator int64_t(byte var)
        {
            return new int64_t(var);
        }

        /* Math */
        public static int64_t operator +(int64_t var1, byte var2)       /* + */
        {
            return new int64_t(var1.var + var2);
        }
        public static int64_t operator -(int64_t var1, byte var2)       /* - */
        {
            return new int64_t(var1.var - var2);
        }
        public static int64_t operator *(int64_t var1, byte var2)       /* * */
        {
            return new int64_t(var1.var * var2);
        }
        public static int64_t operator /(int64_t var1, byte var2)       /* / */
        {
            return new int64_t(var1.var / var2);
        }
        public static int64_t operator %(int64_t var1, byte var2)       /* % */
        {
            return new int64_t(var1.var % var2);
        }
        public static int64_t operator &(int64_t var1, byte var2)       /* & */
        {
            return new int64_t(var1.var & var2);
        }
        public static int64_t operator |(int64_t var1, byte var2)       /* | */
        {
            return new int64_t(var1.var | var2);
        }
        public static int64_t operator ^(int64_t var1, byte var2)       /* != */
        {
            return new int64_t(var1.var ^ var2);
        }

        /* Comparison */
        public static bool operator >(int64_t var1, byte var2)          /* > */
        {
            return (var1.var > var2) ? true : false;
        }
        public static bool operator <(int64_t var1, byte var2)          /* < */
        {
            return (var1.var < var2) ? true : false;
        }
        public static bool operator <=(int64_t var1, byte var2)         /* <= */
        {
            return (var1.var <= var2) ? true : false;
        }
        public static bool operator >=(int64_t var1, byte var2)         /* >= */
        {
            return (var1.var >= var2) ? true : false;
        }
        public static bool operator ==(int64_t var1, byte var2)         /* == */
        {
            return (var1.var == var2) ? true : false;
        }
        public static bool operator !=(int64_t var1, byte var2)         /* != */
        {
            return (var1.var != var2) ? true : false;
        }
        #endregion
        #region short
        /* Assignment */
        public static implicit operator short(int64_t obj)
        {
            return (short)obj.var;
        }

        public static implicit operator int64_t(short var)
        {
            return new int64_t(var);
        }

        /* Math */
        public static int64_t operator +(int64_t var1, short var2)      /* + */
        {
            return new int64_t(var1.var + var2);
        }
        public static int64_t operator -(int64_t var1, short var2)      /* - */
        {
            return new int64_t(var1.var - var2);
        }
        public static int64_t operator *(int64_t var1, short var2)      /* * */
        {
            return new int64_t(var1.var * var2);
        }
        public static int64_t operator /(int64_t var1, short var2)      /* / */
        {
            return new int64_t(var1.var / var2);
        }
        public static int64_t operator %(int64_t var1, short var2)      /* % */
        {
            return new int64_t(var1.var % var2);
        }
        public static int64_t operator &(int64_t var1, short var2)      /* & */
        {
            return new int64_t(var1.var & var2);
        }
        public static int64_t operator |(int64_t var1, short var2)      /* | */
        {
            return new int64_t(var1.var | (ushort)var2);
        }
        public static int64_t operator ^(int64_t var1, short var2)      /* != */
        {
            return new int64_t(var1.var ^ var2);
        }

        /* Comparison */
        public static bool operator >(int64_t var1, short var2)         /* > */
        {
            return (var1.var > var2) ? true : false;
        }
        public static bool operator <(int64_t var1, short var2)         /* < */
        {
            return (var1.var < var2) ? true : false;
        }
        public static bool operator <=(int64_t var1, short var2)        /* <= */
        {
            return (var1.var <= var2) ? true : false;
        }
        public static bool operator >=(int64_t var1, short var2)        /* >= */
        {
            return (var1.var >= var2) ? true : false;
        }
        public static bool operator ==(int64_t var1, short var2)        /* == */
        {
            return (var1.var == var2) ? true : false;
        }
        public static bool operator !=(int64_t var1, short var2)        /* != */
        {
            return (var1.var != var2) ? true : false;
        }
        #endregion
        #region ushort
        /* Assignment */
        public static implicit operator ushort(int64_t obj)
        {
            return (ushort)obj.var;
        }

        public static implicit operator int64_t(ushort var)
        {
            return new int64_t(var);
        }

        /* Math */
        public static int64_t operator +(int64_t var1, ushort var2)     /* + */
        {
            return new int64_t(var1.var + var2);
        }
        public static int64_t operator -(int64_t var1, ushort var2)     /* - */
        {
            return new int64_t(var1.var - var2);
        }
        public static int64_t operator *(int64_t var1, ushort var2)     /* * */
        {
            return new int64_t(var1.var * var2);
        }
        public static int64_t operator /(int64_t var1, ushort var2)     /* / */
        {
            return new int64_t(var1.var / var2);
        }
        public static int64_t operator %(int64_t var1, ushort var2)     /* % */
        {
            return new int64_t(var1.var % var2);
        }
        public static int64_t operator &(int64_t var1, ushort var2)     /* & */
        {
            return new int64_t(var1.var & var2);
        }
        public static int64_t operator |(int64_t var1, ushort var2)     /* | */
        {
            return new int64_t(var1.var | var2);
        }
        public static int64_t operator ^(int64_t var1, ushort var2)     /* != */
        {
            return new int64_t(var1.var ^ var2);
        }

        /* Comparison */
        public static bool operator >(int64_t var1, ushort var2)        /* > */
        {
            return (var1.var > var2) ? true : false;
        }
        public static bool operator <(int64_t var1, ushort var2)        /* < */
        {
            return (var1.var < var2) ? true : false;
        }
        public static bool operator <=(int64_t var1, ushort var2)       /* <= */
        {
            return (var1.var <= var2) ? true : false;
        }
        public static bool operator >=(int64_t var1, ushort var2)       /* >= */
        {
            return (var1.var >= var2) ? true : false;
        }
        public static bool operator ==(int64_t var1, ushort var2)       /* == */
        {
            return (var1.var == var2) ? true : false;
        }
        public static bool operator !=(int64_t var1, ushort var2)       /* != */
        {
            return (var1.var != var2) ? true : false;
        }
        #endregion
        #region int
        /* Assignment */
        public static implicit operator int(int64_t obj)
        {
            return (int)obj.var;
        }

        public static implicit operator int64_t(int var)
        {
            return new int64_t(var);
        }

        /* Math */
        public static int64_t operator +(int64_t var1, int var2)        /* + */
        {
            return new int64_t(var1.var + var2);
        }
        public static int64_t operator -(int64_t var1, int var2)        /* - */
        {
            return new int64_t(var1.var - var2);
        }
        public static int64_t operator *(int64_t var1, int var2)        /* * */
        {
            return new int64_t(var1.var * var2);
        }
        public static int64_t operator /(int64_t var1, int var2)        /* / */
        {
            return new int64_t(var1.var / var2);
        }
        public static int64_t operator %(int64_t var1, int var2)        /* % */
        {
            return new int64_t(var1.var % var2);
        }
        public static int64_t operator &(int64_t var1, int var2)        /* & */
        {
            return new int64_t(var1.var & var2);
        }
        public static int64_t operator |(int64_t var1, int var2)        /* | */
        {
            return new int64_t(var1.var | (uint)var2);
        }
        public static int64_t operator ^(int64_t var1, int var2)        /* ^ */
        {
            return new int64_t(var1.var ^ var2);
        }

        /* Comparison */
        public static bool operator >(int64_t var1, int var2)           /* > */
        {
            return (var1.var > var2) ? true : false;
        }
        public static bool operator <(int64_t var1, int var2)           /* < */
        {
            return (var1.var < var2) ? true : false;
        }
        public static bool operator <=(int64_t var1, int var2)          /* <= */
        {
            return (var1.var <= var2) ? true : false;
        }
        public static bool operator >=(int64_t var1, int var2)          /* >= */
        {
            return (var1.var >= var2) ? true : false;
        }
        public static bool operator ==(int64_t var1, int var2)          /* == */
        {
            return (var1.var == var2) ? true : false;
        }
        public static bool operator !=(int64_t var1, int var2)          /* != */
        {
            return (var1.var != var2) ? true : false;
        }
        public static int64_t operator >>(int64_t var1, int var2)       /* >> */
        {
            return new int64_t(var1.var >> var2);
        }
        public static int64_t operator <<(int64_t var1, int var2)       /* << */
        {
            return new int64_t(var1.var << var2);
        }
        #endregion
        #region uint
        /* Assignment */
        public static implicit operator uint(int64_t obj)
        {
            return (uint)obj.var;
        }

        public static implicit operator int64_t(uint var)
        {
            return new int64_t(var);
        }

        /* Math */
        public static int64_t operator +(int64_t var1, uint var2)       /* + */
        {
            return new int64_t(var1.var + var2);
        }
        public static int64_t operator -(int64_t var1, uint var2)       /* - */
        {
            return new int64_t(var1.var - var2);
        }
        public static int64_t operator *(int64_t var1, uint var2)       /* * */
        {
            return new int64_t(var1.var * var2);
        }
        public static int64_t operator /(int64_t var1, uint var2)       /* / */
        {
            return new int64_t(var1.var / var2);
        }
        public static int64_t operator %(int64_t var1, uint var2)       /* % */
        {
            return new int64_t(var1.var % var2);
        }
        public static int64_t operator &(int64_t var1, uint var2)       /* & */
        {
            return new int64_t(var1.var & var2);
        }
        public static int64_t operator |(int64_t var1, uint var2)       /* | */
        {
            return new int64_t(var1.var | var2);
        }
        public static int64_t operator ^(int64_t var1, uint var2)       /* != */
        {
            return new int64_t(var1.var ^ var2);
        }

        /* Comparison */
        public static bool operator >(int64_t var1, uint var2)          /* > */
        {
            return (var1.var > var2) ? true : false;
        }
        public static bool operator <(int64_t var1, uint var2)          /* < */
        {
            return (var1.var < var2) ? true : false;
        }
        public static bool operator <=(int64_t var1, uint var2)         /* <= */
        {
            return (var1.var <= var2) ? true : false;
        }
        public static bool operator >=(int64_t var1, uint var2)         /* >= */
        {
            return (var1.var >= var2) ? true : false;
        }
        public static bool operator ==(int64_t var1, uint var2)         /* == */
        {
            return (var1.var == var2) ? true : false;
        }
        public static bool operator !=(int64_t var1, uint var2)         /* != */
        {
            return (var1.var != var2) ? true : false;
        }
        #endregion
        #region long
        /* Assignment */
        public static implicit operator long(int64_t obj)
        {
            return obj.var;
        }

        public static implicit operator int64_t(long var)
        {
            return new int64_t(var);
        }

        /* Math */
        public static int64_t operator +(int64_t var1, long var2)       /* + */
        {
            return new int64_t(var1.var + var2);
        }
        public static int64_t operator -(int64_t var1, long var2)       /* - */
        {
            return new int64_t(var1.var - var2);
        }
        public static int64_t operator *(int64_t var1, long var2)       /* * */
        {
            return new int64_t(var1.var * var2);
        }
        public static int64_t operator /(int64_t var1, long var2)       /* / */
        {
            return new int64_t(var1.var / var2);
        }
        public static int64_t operator %(int64_t var1, long var2)       /* % */
        {
            return new int64_t(var1.var % var2);
        }
        public static int64_t operator &(int64_t var1, long var2)       /* & */
        {
            return new int64_t(var1.var & var2);
        }
        public static int64_t operator |(int64_t var1, long var2)       /* | */
        {
            return new int64_t(var1.var | var2);
        }
        public static int64_t operator ^(int64_t var1, long var2)       /* != */
        {
            return new int64_t(var1.var ^ var2);
        }

        /* Comparison */
        public static bool operator >(int64_t var1, long var2)          /* > */
        {
            return (var1.var > var2) ? true : false;
        }
        public static bool operator <(int64_t var1, long var2)          /* < */
        {
            return (var1.var < var2) ? true : false;
        }
        public static bool operator <=(int64_t var1, long var2)         /* <= */
        {
            return (var1.var <= var2) ? true : false;
        }
        public static bool operator >=(int64_t var1, long var2)         /* >= */
        {
            return (var1.var >= var2) ? true : false;
        }
        public static bool operator ==(int64_t var1, long var2)         /* == */
        {
            return (var1.var == var2) ? true : false;
        }
        public static bool operator !=(int64_t var1, long var2)         /* != */
        {
            return (var1.var != var2) ? true : false;
        }
        #endregion
        #region ulong
        /* Assignment */
        public static implicit operator ulong(int64_t obj)
        {
            return (ulong)obj.var;
        }

        public static implicit operator int64_t(ulong var)
        {
            return new int64_t(var);
        }

        /* Math */
        public static int64_t operator +(int64_t var1, ulong var2)      /* + */
        {
            return new int64_t((ulong)var1.var + var2);
        }
        public static int64_t operator -(int64_t var1, ulong var2)      /* - */
        {
            return new int64_t((ulong)var1.var - var2);
        }
        public static int64_t operator *(int64_t var1, ulong var2)      /* * */
        {
            return new int64_t((ulong)var1.var * var2);
        }
        public static int64_t operator /(int64_t var1, ulong var2)      /* / */
        {
            return new int64_t((ulong)var1.var / var2);
        }
        public static int64_t operator %(int64_t var1, ulong var2)      /* % */
        {
            return new int64_t((ulong)var1.var % var2);
        }
        public static int64_t operator &(int64_t var1, ulong var2)      /* & */
        {
            return new int64_t((ulong)var1.var & var2);
        }
        public static int64_t operator |(int64_t var1, ulong var2)      /* | */
        {
            return new int64_t((ulong)var1.var | var2);
        }
        public static int64_t operator ^(int64_t var1, ulong var2)      /* != */
        {
            return new int64_t((ulong)var1.var ^ var2);
        }

        /* Comparison */
        public static bool operator >(int64_t var1, ulong var2)         /* > */
        {
            return ((ulong)var1.var > var2) ? true : false;
        }
        public static bool operator <(int64_t var1, ulong var2)         /* < */
        {
            return ((ulong)var1.var < var2) ? true : false;
        }
        public static bool operator <=(int64_t var1, ulong var2)        /* <= */
        {
            return ((ulong)var1.var <= var2) ? true : false;
        }
        public static bool operator >=(int64_t var1, ulong var2)        /* >= */
        {
            return ((ulong)var1.var >= var2) ? true : false;
        }
        public static bool operator ==(int64_t var1, ulong var2)        /* == */
        {
            return ((ulong)var1.var == var2) ? true : false;
        }
        public static bool operator !=(int64_t var1, ulong var2)        /* != */
        {
            return ((ulong)var1.var != var2) ? true : false;
        }
        #endregion

        #region float
        /* Math */
        public static int64_t operator +(int64_t var1, float var2)      /* + */
        {
            return new int64_t(var1.var + var2);
        }
        public static int64_t operator -(int64_t var1, float var2)      /* - */
        {
            return new int64_t(var1.var - var2);
        }
        public static int64_t operator *(int64_t var1, float var2)      /* * */
        {
            return new int64_t(var1.var * var2);
        }
        public static int64_t operator /(int64_t var1, float var2)      /* / */
        {
            return new int64_t(var1.var / var2);
        }
        public static int64_t operator %(int64_t var1, float var2)      /* % */
        {
            return new int64_t(var1.var % var2);
        }
        public static int64_t operator &(int64_t var1, float var2)      /* & */
        {
            throw new System.ArgumentException(System.String.Format("& operator cannot be applied with float parameter {0}", var2));
        }
        public static int64_t operator |(int64_t var1, float var2)      /* | */
        {
            throw new System.ArgumentException(System.String.Format("| operator cannot be applied with float parameter {0}", var2));
        }
        public static int64_t operator ^(int64_t var1, float var2)      /* != */
        {
            throw new System.ArgumentException(System.String.Format("^ operator cannot be applied with float parameter {0}", var2));
        }

        /* Comparison */
        public static bool operator >(int64_t var1, float var2)         /* > */
        {
            return (var1.var > var2) ? true : false;
        }
        public static bool operator <(int64_t var1, float var2)         /* < */
        {
            return (var1.var < var2) ? true : false;
        }
        public static bool operator <=(int64_t var1, float var2)        /* <= */
        {
            return (var1.var <= var2) ? true : false;
        }
        public static bool operator >=(int64_t var1, float var2)        /* >= */
        {
            return (var1.var >= var2) ? true : false;
        }
        public static bool operator ==(int64_t var1, float var2)        /* == */
        {
            return (var1.var == var2) ? true : false;
        }
        public static bool operator !=(int64_t var1, float var2)        /* != */
        {
            return (var1.var != var2) ? true : false;
        }
        #endregion
        #region double
        /* Math */
        public static int64_t operator +(int64_t var1, double var2)     /* + */
        {
            return new int64_t(var1.var + var2);
        }
        public static int64_t operator -(int64_t var1, double var2)     /* - */
        {
            return new int64_t(var1.var - var2);
        }
        public static int64_t operator *(int64_t var1, double var2)     /* * */
        {
            return new int64_t(var1.var * var2);
        }
        public static int64_t operator /(int64_t var1, double var2)     /* / */
        {
            return new int64_t(var1.var / var2);
        }
        public static int64_t operator %(int64_t var1, double var2)     /* % */
        {
            return new int64_t(var1.var % var2);
        }
        public static int64_t operator &(int64_t var1, double var2)     /* & */
        {
            throw new System.ArgumentException(System.String.Format("& operator cannot be applied with double parameter {0}", var2));
        }
        public static int64_t operator |(int64_t var1, double var2)     /* | */
        {
            throw new System.ArgumentException(System.String.Format("| operator cannot be applied with double parameter {0}", var2));
        }
        public static int64_t operator ^(int64_t var1, double var2)     /* != */
        {
            throw new System.ArgumentException(System.String.Format("^ operator cannot be applied with double parameter {0}", var2));
        }

        /* Comparison */
        public static bool operator >(int64_t var1, double var2)        /* > */
        {
            return (var1.var > var2) ? true : false;
        }
        public static bool operator <(int64_t var1, double var2)        /* < */
        {
            return (var1.var < var2) ? true : false;
        }
        public static bool operator <=(int64_t var1, double var2)       /* <= */
        {
            return (var1.var <= var2) ? true : false;
        }
        public static bool operator >=(int64_t var1, double var2)       /* >= */
        {
            return (var1.var >= var2) ? true : false;
        }
        public static bool operator ==(int64_t var1, double var2)       /* == */
        {
            return (var1.var == var2) ? true : false;
        }
        public static bool operator !=(int64_t var1, double var2)       /* != */
        {
            return (var1.var != var2) ? true : false;
        }
        #endregion
        #endregion
        #endregion

        #region specials
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        public override string ToString()
        {
            return var.ToString();
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public int64_t Increment()
        {
            this.var++;
            return this;
        }
        public int64_t Decrement()
        {
            this.var--;
            return this;
        }
        #endregion
    }

    /****************************** uint64_t **********************************/
    class uint64_t
    {
        public ulong var = 0;

        #region Constructors
        public uint64_t()               { var = 0; }
        public uint64_t(byte value)     { var = (ulong)value; }
        public uint64_t(sbyte value)    { var = (ulong)value; }
        public uint64_t(short value)    { var = (ulong)value; }
        public uint64_t(ushort value)   { var = (ulong)value; }
        public uint64_t(int value)      { var = (ulong)value; }
        public uint64_t(uint value)     { var = (ulong)value; }
        public uint64_t(long value)     { var = (ulong)value; }
        public uint64_t(ulong value)    { var = value; }
        public uint64_t(float value)    { var = System.Convert.ToUInt64(System.Math.Truncate(value)); }
        public uint64_t(double value)   { var = System.Convert.ToUInt64(System.Math.Truncate(value)); }
        public uint64_t(int8_t value)   { var = (ulong)value.var; }
        public uint64_t(uint8_t value)  { var = (ulong)value.var; }
        public uint64_t(int16_t value)  { var = (ulong)value.var; }
        public uint64_t(uint16_t value) { var = (ulong)value.var; }
        public uint64_t(int32_t value)  { var = (ulong)value.var; }
        public uint64_t(uint32_t value) { var = (ulong)value.var; }
        public uint64_t(int64_t value)  { var = (ulong)value.var; }
        public uint64_t(uint64_t value) { var = value.var; }
        #endregion

        #region types
        #region new types
        #region int8_t
        /* Assignment */
        public static implicit operator uint64_t(int8_t obj)
        {
            return new uint64_t(obj);
        }

        /* Math */
        public static uint64_t operator +(uint64_t var1, int8_t var2)   /* + */
        {                                                               
            return new uint64_t(var1.var + (byte)var2.var);                   
        }                                                               
        public static uint64_t operator -(uint64_t var1, int8_t var2)   /* - */
        {                                                               
            return new uint64_t(var1.var - (byte)var2.var);                   
        }                                                               
        public static uint64_t operator *(uint64_t var1, int8_t var2)   /* * */
        {                                                               
            return new uint64_t(var1.var * (byte)var2.var);                   
        }                                                               
        public static uint64_t operator /(uint64_t var1, int8_t var2)   /* / */
        {                                                               
            return new uint64_t(var1.var / (byte)var2.var);                   
        }                                                               
        public static uint64_t operator %(uint64_t var1, int8_t var2)   /* % */
        {                                                               
            return new uint64_t(var1.var % (byte)var2.var);                   
        }                                                               
        public static uint64_t operator &(uint64_t var1, int8_t var2)   /* & */
        {                                                               
            return new uint64_t(var1.var & (byte)var2.var);                   
        }                                                               
        public static uint64_t operator |(uint64_t var1, int8_t var2)   /* | */
        {                                                               
            return new uint64_t(var1.var | (byte)var2.var);                   
        }                                                               
        public static uint64_t operator ^(uint64_t var1, int8_t var2)   /* ^ */
        {
            return new uint64_t(var1.var ^ (byte)var2.var);
        }

        /* Comparison */
        public static bool operator >(uint64_t var1, int8_t var2)       /* > */
        {                                                               
            return (var1.var > (byte)var2.var) ? true : false;          
        }                                                               
        public static bool operator <(uint64_t var1, int8_t var2)       /* < */
        {                                                               
            return (var1.var < (byte)var2.var) ? true : false;          
        }                                                               
        public static bool operator <=(uint64_t var1, int8_t var2)      /* <= */
        {                                                               
            return (var1.var <= (byte)var2.var) ? true : false;         
        }                                                               
        public static bool operator >=(uint64_t var1, int8_t var2)      /* >= */
        {                                                               
            return (var1.var >= (byte)var2.var) ? true : false;         
        }                                                               
        public static bool operator ==(uint64_t var1, int8_t var2)      /* == */
        {                                                               
            return (var1.var == (byte)var2.var) ? true : false;         
        }                                                               
        public static bool operator !=(uint64_t var1, int8_t var2)      /* != */
        {
            return (var1.var != (byte)var2.var) ? true : false;
        }
        #endregion
        #region uint8_t
        /* Assignment */
        public static implicit operator uint64_t(uint8_t obj)
        {
            return new uint64_t(obj);
        }

        /* Math */
        public static uint64_t operator +(uint64_t var1, uint8_t var2)  /* + */
        {
            return new uint64_t(var1.var + var2.var);
        }
        public static uint64_t operator -(uint64_t var1, uint8_t var2)  /* - */
        {
            return new uint64_t(var1.var - var2.var);
        }
        public static uint64_t operator *(uint64_t var1, uint8_t var2)  /* * */
        {
            return new uint64_t(var1.var * var2.var);
        }
        public static uint64_t operator /(uint64_t var1, uint8_t var2)  /* / */
        {
            return new uint64_t(var1.var / var2.var);
        }
        public static uint64_t operator %(uint64_t var1, uint8_t var2)  /* % */
        {
            return new uint64_t(var1.var % var2.var);
        }
        public static uint64_t operator &(uint64_t var1, uint8_t var2)  /* & */
        {
            return new uint64_t(var1.var & var2.var);
        }
        public static uint64_t operator |(uint64_t var1, uint8_t var2)  /* | */
        {
            return new uint64_t(var1.var | var2.var);
        }
        public static uint64_t operator ^(uint64_t var1, uint8_t var2)  /* ^ */
        {
            return new uint64_t(var1.var ^ var2.var);
        }

        /* Comparison */
        public static bool operator >(uint64_t var1, uint8_t var2)      /* > */
        {                                                               
            return (var1.var > var2.var) ? true : false;                
        }                                                               
        public static bool operator <(uint64_t var1, uint8_t var2)      /* < */
        {                                                               
            return (var1.var < var2.var) ? true : false;                
        }                                                               
        public static bool operator <=(uint64_t var1, uint8_t var2)     /* <= */
        {                                                               
            return (var1.var <= var2.var) ? true : false;               
        }                                                               
        public static bool operator >=(uint64_t var1, uint8_t var2)     /* >= */
        {                                                               
            return (var1.var >= var2.var) ? true : false;               
        }                                                               
        public static bool operator ==(uint64_t var1, uint8_t var2)     /* == */
        {                                                               
            return (var1.var == var2.var) ? true : false;               
        }                                                               
        public static bool operator !=(uint64_t var1, uint8_t var2)     /* != */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region int16_t
        /* Assignment */
        public static implicit operator uint64_t(int16_t obj)
        {
            return new uint64_t(obj);
        }

        /* Math */
        public static uint64_t operator +(uint64_t var1, int16_t var2)  /* + */
        {
            return new uint64_t(var1.var + (ushort)var2.var);
        }
        public static uint64_t operator -(uint64_t var1, int16_t var2)  /* - */
        {
            return new uint64_t(var1.var - (ushort)var2.var);
        }
        public static uint64_t operator *(uint64_t var1, int16_t var2)  /* * */
        {
            return new uint64_t(var1.var * (ushort)var2.var);
        }
        public static uint64_t operator /(uint64_t var1, int16_t var2)  /* / */
        {
            return new uint64_t(var1.var / (ushort)var2.var);
        }
        public static uint64_t operator %(uint64_t var1, int16_t var2)  /* % */
        {
            return new uint64_t(var1.var % (ushort)var2.var);
        }
        public static uint64_t operator &(uint64_t var1, int16_t var2)  /* & */
        {
            return new uint64_t(var1.var & (ushort)var2.var);
        }
        public static uint64_t operator |(uint64_t var1, int16_t var2)  /* | */
        {
            return new uint64_t(var1.var | (ushort)var2.var);
        }
        public static uint64_t operator ^(uint64_t var1, int16_t var2)  /* ^ */
        {
            return new uint64_t(var1.var ^ (ushort)var2.var);
        }

        /* Comparison */
        public static bool operator >(uint64_t var1, int16_t var2)      /* > */
        {                                                               
            return (var1.var > (ushort)var2.var) ? true : false;        
        }                                                               
        public static bool operator <(uint64_t var1, int16_t var2)      /* < */
        {                                                               
            return (var1.var < (ushort)var2.var) ? true : false;        
        }                                                               
        public static bool operator <=(uint64_t var1, int16_t var2)     /* <= */
        {                                                               
            return (var1.var <= (ushort)var2.var) ? true : false;       
        }                                                               
        public static bool operator >=(uint64_t var1, int16_t var2)     /* >= */
        {                                                               
            return (var1.var >= (ushort)var2.var) ? true : false;       
        }                                                               
        public static bool operator ==(uint64_t var1, int16_t var2)     /* == */
        {                                                               
            return (var1.var == (ushort)var2.var) ? true : false;       
        }                                                               
        public static bool operator !=(uint64_t var1, int16_t var2)     /* != */
        {
            return (var1.var != (ushort)var2.var) ? true : false;
        }
        #endregion
        #region uint16_t
        /* Assignment */
        public static implicit operator uint64_t(uint16_t obj)
        {
            return new uint64_t(obj);
        }

        /* Math */
        public static uint64_t operator +(uint64_t var1, uint16_t var2) /* + */
        {
            return new uint64_t(var1.var + var2.var);
        }
        public static uint64_t operator -(uint64_t var1, uint16_t var2) /* - */
        {
            return new uint64_t(var1.var - var2.var);
        }
        public static uint64_t operator *(uint64_t var1, uint16_t var2) /* * */
        {
            return new uint64_t(var1.var * var2.var);
        }
        public static uint64_t operator /(uint64_t var1, uint16_t var2) /* / */
        {
            return new uint64_t(var1.var / var2.var);
        }
        public static uint64_t operator %(uint64_t var1, uint16_t var2) /* % */
        {
            return new uint64_t(var1.var % var2.var);
        }
        public static uint64_t operator &(uint64_t var1, uint16_t var2) /* & */
        {
            return new uint64_t(var1.var & var2.var);
        }
        public static uint64_t operator |(uint64_t var1, uint16_t var2) /* | */
        {
            return new uint64_t(var1.var | var2.var);
        }
        public static uint64_t operator ^(uint64_t var1, uint16_t var2) /* ^ */
        {
            return new uint64_t(var1.var ^ var2.var);
        }

        /* Comparison */
        public static bool operator >(uint64_t var1, uint16_t var2)     /* > */
        {
            return (var1.var > var2.var) ? true : false;
        }
        public static bool operator <(uint64_t var1, uint16_t var2)     /* < */
        {
            return (var1.var < var2.var) ? true : false;
        }
        public static bool operator <=(uint64_t var1, uint16_t var2)    /* <= */
        {
            return (var1.var <= var2.var) ? true : false;
        }
        public static bool operator >=(uint64_t var1, uint16_t var2)    /* >= */
        {
            return (var1.var >= var2.var) ? true : false;
        }
        public static bool operator ==(uint64_t var1, uint16_t var2)    /* == */
        {
            return (var1.var == var2.var) ? true : false;
        }
        public static bool operator !=(uint64_t var1, uint16_t var2)    /* != */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region int32_t
        /* Assignment */
        public static implicit operator uint64_t(int32_t obj)
        {
            return new uint64_t(obj);
        }

        /* Math */
        public static uint64_t operator +(uint64_t var1, int32_t var2)  /* + */
        {
            return new uint64_t(var1.var + (uint)var2.var);
        }
        public static uint64_t operator -(uint64_t var1, int32_t var2)  /* - */
        {
            return new uint64_t(var1.var - (uint)var2.var);
        }
        public static uint64_t operator *(uint64_t var1, int32_t var2)  /* * */
        {
            return new uint64_t(var1.var * (uint)var2.var);
        }
        public static uint64_t operator /(uint64_t var1, int32_t var2)  /* / */
        {
            return new uint64_t(var1.var / (uint)var2.var);
        }
        public static uint64_t operator %(uint64_t var1, int32_t var2)  /* % */
        {
            return new uint64_t(var1.var % (uint)var2.var);
        }
        public static uint64_t operator &(uint64_t var1, int32_t var2)  /* & */
        {
            return new uint64_t(var1.var & (uint)var2.var);
        }
        public static uint64_t operator |(uint64_t var1, int32_t var2)  /* | */
        {
            return new uint64_t(var1.var | (uint)var2.var);
        }
        public static uint64_t operator ^(uint64_t var1, int32_t var2)  /* ^ */
        {
            return new uint64_t(var1.var ^ (uint)var2.var);
        }

        /* Comparison */
        public static bool operator >(uint64_t var1, int32_t var2)      /* > */
        {                                                               
            return (var1.var > (uint)var2.var) ? true : false;        
        }                                                               
        public static bool operator <(uint64_t var1, int32_t var2)      /* < */
        {                                                               
            return (var1.var < (uint)var2.var) ? true : false;        
        }                                                               
        public static bool operator <=(uint64_t var1, int32_t var2)     /* <= */
        {                                                               
            return (var1.var <= (uint)var2.var) ? true : false;       
        }                                                               
        public static bool operator >=(uint64_t var1, int32_t var2)     /* >= */
        {                                                               
            return (var1.var >= (uint)var2.var) ? true : false;       
        }                                                               
        public static bool operator ==(uint64_t var1, int32_t var2)     /* == */
        {                                                               
            return (var1.var == (uint)var2.var) ? true : false;       
        }                                                               
        public static bool operator !=(uint64_t var1, int32_t var2)     /* != */
        {
            return (var1.var != (uint)var2.var) ? true : false;
        }
        #endregion
        #region uint32_t
        /* Assignment */
        public static implicit operator uint64_t(uint32_t obj)
        {
            return new uint64_t(obj);
        }

        /* Math */
        public static uint64_t operator +(uint64_t var1, uint32_t var2) /* + */
        {                                                               
            return new uint64_t(var1.var + var2.var);                   
        }                                                               
        public static uint64_t operator -(uint64_t var1, uint32_t var2) /* - */
        {                                                               
            return new uint64_t(var1.var - var2.var);                   
        }                                                               
        public static uint64_t operator *(uint64_t var1, uint32_t var2) /* * */
        {                                                               
            return new uint64_t(var1.var * var2.var);                   
        }                                                               
        public static uint64_t operator /(uint64_t var1, uint32_t var2) /* / */
        {                                                               
            return new uint64_t(var1.var / var2.var);                   
        }                                                               
        public static uint64_t operator %(uint64_t var1, uint32_t var2) /* % */
        {                                                               
            return new uint64_t(var1.var % var2.var);                   
        }                                                               
        public static uint64_t operator &(uint64_t var1, uint32_t var2) /* & */
        {                                                               
            return new uint64_t(var1.var & var2.var);                   
        }                                                               
        public static uint64_t operator |(uint64_t var1, uint32_t var2) /* | */
        {                                                               
            return new uint64_t(var1.var | var2.var);                   
        }                                                               
        public static uint64_t operator ^(uint64_t var1, uint32_t var2) /* ^ */
        {
            return new uint64_t(var1.var ^ var2.var);
        }

        /* Comparison */
        public static bool operator >(uint64_t var1, uint32_t var2)     /* > */
        {
            return (var1.var > var2.var) ? true : false;
        }
        public static bool operator <(uint64_t var1, uint32_t var2)     /* < */
        {
            return (var1.var < var2.var) ? true : false;
        }
        public static bool operator <=(uint64_t var1, uint32_t var2)    /* <= */
        {
            return (var1.var <= var2.var) ? true : false;
        }
        public static bool operator >=(uint64_t var1, uint32_t var2)    /* >= */
        {
            return (var1.var >= var2.var) ? true : false;
        }
        public static bool operator ==(uint64_t var1, uint32_t var2)    /* == */
        {
            return (var1.var == var2.var) ? true : false;
        }
        public static bool operator !=(uint64_t var1, uint32_t var2)    /* != */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #region int64_t
        /* Assignment */
        public static implicit operator uint64_t(int64_t obj)
        {
            return new uint64_t(obj);
        }

        /* Math */
        public static uint64_t operator +(uint64_t var1, int64_t var2)  /* + */
        {
            return new uint64_t(var1.var + (ulong)var2.var);
        }
        public static uint64_t operator -(uint64_t var1, int64_t var2)  /* - */
        {
            return new uint64_t(var1.var - (ulong)var2.var);
        }
        public static uint64_t operator *(uint64_t var1, int64_t var2)  /* * */
        {
            return new uint64_t(var1.var * (ulong)var2.var);
        }
        public static uint64_t operator /(uint64_t var1, int64_t var2)  /* / */
        {
            return new uint64_t(var1.var / (ulong)var2.var);
        }
        public static uint64_t operator %(uint64_t var1, int64_t var2)  /* % */
        {
            return new uint64_t(var1.var % (ulong)var2.var);
        }
        public static uint64_t operator &(uint64_t var1, int64_t var2)  /* & */
        {
            return new uint64_t(var1.var & (ulong)var2.var);
        }
        public static uint64_t operator |(uint64_t var1, int64_t var2)  /* | */
        {
            return new uint64_t(var1.var | (ulong)var2.var);
        }
        public static uint64_t operator ^(uint64_t var1, int64_t var2)  /* ^ */
        {
            return new uint64_t(var1.var ^ (ulong)var2.var);
        }

        /* Comparison */
        public static bool operator >(uint64_t var1, int64_t var2)      /* > */
        {                                                               
            return (var1.var > (ulong)var2.var) ? true : false;        
        }                                                               
        public static bool operator <(uint64_t var1, int64_t var2)      /* < */
        {                                                               
            return (var1.var < (ulong)var2.var) ? true : false;        
        }                                                               
        public static bool operator <=(uint64_t var1, int64_t var2)     /* <= */
        {                                                               
            return (var1.var <= (ulong)var2.var) ? true : false;       
        }                                                               
        public static bool operator >=(uint64_t var1, int64_t var2)     /* >= */
        {                                                               
            return (var1.var >= (ulong)var2.var) ? true : false;       
        }                                                               
        public static bool operator ==(uint64_t var1, int64_t var2)     /* == */
        {                                                               
            return (var1.var == (ulong)var2.var) ? true : false;       
        }                                                               
        public static bool operator !=(uint64_t var1, int64_t var2)     /* != */
        {
            return (var1.var != (ulong)var2.var) ? true : false;
        }
        #endregion
        #region uint64_t
        /* Unary operators */
        public static uint64_t operator ++(uint64_t obj)                /* ++ */
        {
            obj.Increment();
            return obj;
        }
        public static uint64_t operator --(uint64_t obj)                /* -- */
        {
            obj.Decrement();
            return obj;
        }
        public static uint64_t operator -(uint64_t obj)                 /* - (unary) */
        {
            return new uint64_t(0UL - obj.var);
        }
        public static uint64_t operator +(uint64_t obj)                 /* + (unary) */
        {
            return new uint64_t(obj);
        }
        public static uint64_t operator ~(uint64_t obj)                 /* ~ */
        {
            return new uint64_t(~obj.var);
        }

        /* Math */
        public static uint64_t operator +(uint64_t var1, uint64_t var2) /* + */
        {
            return new uint64_t(var1.var + var2.var);
        }
        public static uint64_t operator -(uint64_t var1, uint64_t var2) /* - */
        {
            return new uint64_t(var1.var - var2.var);
        }
        public static uint64_t operator *(uint64_t var1, uint64_t var2) /* * */
        {
            return new uint64_t(var1.var * var2.var);
        }
        public static uint64_t operator /(uint64_t var1, uint64_t var2) /* / */
        {
            return new uint64_t(var1.var / var2.var);
        }
        public static uint64_t operator %(uint64_t var1, uint64_t var2) /* % */
        {
            return new uint64_t(var1.var % var2.var);
        }
        public static uint64_t operator &(uint64_t var1, uint64_t var2) /* & */
        {
            return new uint64_t(var1.var & var2.var);
        }
        public static uint64_t operator |(uint64_t var1, uint64_t var2) /* | */
        {
            return new uint64_t(var1.var | var2.var);
        }
        public static uint64_t operator ^(uint64_t var1, uint64_t var2) /* ^ */
        {
            return new uint64_t(var1.var ^ var2.var);
        }

        /* Comparison */
        public static bool operator >(uint64_t var1, uint64_t var2)     /* > */
        {
            return (var1.var > var2.var) ? true : false;
        }
        public static bool operator <(uint64_t var1, uint64_t var2)     /* < */
        {
            return (var1.var < var2.var) ? true : false;
        }
        public static bool operator <=(uint64_t var1, uint64_t var2)    /* <= */
        {
            return (var1.var <= var2.var) ? true : false;
        }
        public static bool operator >=(uint64_t var1, uint64_t var2)    /* >= */
        {
            return (var1.var >= var2.var) ? true : false;
        }
        public static bool operator ==(uint64_t var1, uint64_t var2)    /* == */
        {
            return (var1.var == var2.var) ? true : false;
        }
        public static bool operator !=(uint64_t var1, uint64_t var2)    /* != */
        {
            return (var1.var != var2.var) ? true : false;
        }
        #endregion
        #endregion

        #region default types
        #region sbyte
        /* Assignment */
        public static implicit operator sbyte(uint64_t obj)
        {
            return (sbyte)obj.var;
        }

        public static implicit operator uint64_t(sbyte var)
        {
            return new uint64_t(var);
        }

        /* Math */
        public static uint64_t operator +(uint64_t var1, sbyte var2)    /* + */
        {
            return new uint64_t(var1.var + (byte)var2);
        }
        public static uint64_t operator -(uint64_t var1, sbyte var2)    /* - */
        {
            return new uint64_t(var1.var - (byte)var2);
        }
        public static uint64_t operator *(uint64_t var1, sbyte var2)    /* * */
        {
            return new uint64_t(var1.var * (byte)var2);
        }
        public static uint64_t operator /(uint64_t var1, sbyte var2)    /* / */
        {
            return new uint64_t(var1.var / (byte)var2);
        }
        public static uint64_t operator %(uint64_t var1, sbyte var2)    /* % */
        {
            return new uint64_t(var1.var % (byte)var2);
        }
        public static uint64_t operator &(uint64_t var1, sbyte var2)    /* & */
        {
            return new uint64_t(var1.var & (byte)var2);
        }
        public static uint64_t operator |(uint64_t var1, sbyte var2)    /* | */
        {
            return new uint64_t(var1.var | (byte)var2);
        }
        public static uint64_t operator ^(uint64_t var1, sbyte var2)    /* != */
        {
            return new uint64_t(var1.var ^ (byte)var2);
        }

        /* Comparison */
        public static bool operator >(uint64_t var1, sbyte var2)        /* > */
        {
            return (var1.var > (byte)var2) ? true : false;
        }
        public static bool operator <(uint64_t var1, sbyte var2)        /* < */
        {
            return (var1.var < (byte)var2) ? true : false;
        }
        public static bool operator <=(uint64_t var1, sbyte var2)       /* <= */
        {
            return (var1.var <= (byte)var2) ? true : false;
        }
        public static bool operator >=(uint64_t var1, sbyte var2)       /* >= */
        {
            return (var1.var >= (byte)var2) ? true : false;
        }
        public static bool operator ==(uint64_t var1, sbyte var2)       /* == */
        {
            return (var1.var == (byte)var2) ? true : false;
        }
        public static bool operator !=(uint64_t var1, sbyte var2)       /* != */
        {
            return (var1.var != (byte)var2) ? true : false;
        }
        #endregion
        #region byte
        /* Assignment */
        public static implicit operator byte(uint64_t obj)
        {
            return (byte)obj.var;
        }

        public static implicit operator uint64_t(byte var)
        {
            return new uint64_t(var);
        }

        /* Math */
        public static uint64_t operator +(uint64_t var1, byte var2)     /* + */
        {
            return new uint64_t(var1.var + var2);
        }
        public static uint64_t operator -(uint64_t var1, byte var2)     /* - */
        {
            return new uint64_t(var1.var - var2);
        }
        public static uint64_t operator *(uint64_t var1, byte var2)     /* * */
        {
            return new uint64_t(var1.var * var2);
        }
        public static uint64_t operator /(uint64_t var1, byte var2)     /* / */
        {
            return new uint64_t(var1.var / var2);
        }
        public static uint64_t operator %(uint64_t var1, byte var2)     /* % */
        {
            return new uint64_t(var1.var % var2);
        }
        public static uint64_t operator &(uint64_t var1, byte var2)     /* & */
        {
            return new uint64_t(var1.var & var2);
        }
        public static uint64_t operator |(uint64_t var1, byte var2)     /* | */
        {
            return new uint64_t(var1.var | var2);
        }
        public static uint64_t operator ^(uint64_t var1, byte var2)     /* != */
        {
            return new uint64_t(var1.var ^ var2);
        }

        /* Comparison */
        public static bool operator >(uint64_t var1, byte var2)         /* > */
        {
            return (var1.var > var2) ? true : false;
        }
        public static bool operator <(uint64_t var1, byte var2)         /* < */
        {
            return (var1.var < var2) ? true : false;
        }
        public static bool operator <=(uint64_t var1, byte var2)        /* <= */
        {
            return (var1.var <= var2) ? true : false;
        }
        public static bool operator >=(uint64_t var1, byte var2)        /* >= */
        {
            return (var1.var >= var2) ? true : false;
        }
        public static bool operator ==(uint64_t var1, byte var2)        /* == */
        {
            return (var1.var == var2) ? true : false;
        }
        public static bool operator !=(uint64_t var1, byte var2)        /* != */
        {
            return (var1.var != var2) ? true : false;
        }
        #endregion
        #region short
        /* Assignment */
        public static implicit operator short(uint64_t obj)
        {
            return (short)obj.var;
        }

        public static implicit operator uint64_t(short var)
        {
            return new uint64_t(var);
        }

        /* Math */
        public static uint64_t operator +(uint64_t var1, short var2)    /* + */
        {
            return new uint64_t(var1.var + (ushort)var2);
        }
        public static uint64_t operator -(uint64_t var1, short var2)    /* - */
        {
            return new uint64_t(var1.var - (ushort)var2);
        }
        public static uint64_t operator *(uint64_t var1, short var2)    /* * */
        {
            return new uint64_t(var1.var * (ushort)var2);
        }
        public static uint64_t operator /(uint64_t var1, short var2)    /* / */
        {
            return new uint64_t(var1.var / (ushort)var2);
        }
        public static uint64_t operator %(uint64_t var1, short var2)    /* % */
        {
            return new uint64_t(var1.var % (ushort)var2);
        }
        public static uint64_t operator &(uint64_t var1, short var2)    /* & */
        {
            return new uint64_t(var1.var & (ushort)var2);
        }
        public static uint64_t operator |(uint64_t var1, short var2)    /* | */
        {
            return new uint64_t(var1.var | (ushort)var2);
        }
        public static uint64_t operator ^(uint64_t var1, short var2)    /* != */
        {
            return new uint64_t(var1.var ^ (ushort)var2);
        }

        /* Comparison */
        public static bool operator >(uint64_t var1, short var2)        /* > */
        {
            return (var1.var > (ushort)var2) ? true : false;
        }
        public static bool operator <(uint64_t var1, short var2)        /* < */
        {
            return (var1.var < (ushort)var2) ? true : false;
        }
        public static bool operator <=(uint64_t var1, short var2)       /* <= */
        {
            return (var1.var <= (ushort)var2) ? true : false;
        }
        public static bool operator >=(uint64_t var1, short var2)       /* >= */
        {
            return (var1.var >= (ushort)var2) ? true : false;
        }
        public static bool operator ==(uint64_t var1, short var2)       /* == */
        {
            return (var1.var == (ushort)var2) ? true : false;
        }
        public static bool operator !=(uint64_t var1, short var2)       /* != */
        {
            return (var1.var != (ushort)var2) ? true : false;
        }
        #endregion
        #region ushort
        /* Assignment */
        public static implicit operator ushort(uint64_t obj)
        {
            return (ushort)obj.var;
        }

        public static implicit operator uint64_t(ushort var)
        {
            return new uint64_t(var);
        }

        /* Math */
        public static uint64_t operator +(uint64_t var1, ushort var2)   /* + */
        {
            return new uint64_t(var1.var + var2);
        }
        public static uint64_t operator -(uint64_t var1, ushort var2)   /* - */
        {
            return new uint64_t(var1.var - var2);
        }
        public static uint64_t operator *(uint64_t var1, ushort var2)   /* * */
        {
            return new uint64_t(var1.var * var2);
        }
        public static uint64_t operator /(uint64_t var1, ushort var2)   /* / */
        {
            return new uint64_t(var1.var / var2);
        }
        public static uint64_t operator %(uint64_t var1, ushort var2)   /* % */
        {
            return new uint64_t(var1.var % var2);
        }
        public static uint64_t operator &(uint64_t var1, ushort var2)   /* & */
        {
            return new uint64_t(var1.var & var2);
        }
        public static uint64_t operator |(uint64_t var1, ushort var2)   /* | */
        {
            return new uint64_t(var1.var | var2);
        }
        public static uint64_t operator ^(uint64_t var1, ushort var2)   /* != */
        {
            return new uint64_t(var1.var ^ var2);
        }

        /* Comparison */
        public static bool operator >(uint64_t var1, ushort var2)       /* > */
        {
            return (var1.var > var2) ? true : false;
        }
        public static bool operator <(uint64_t var1, ushort var2)       /* < */
        {
            return (var1.var < var2) ? true : false;
        }
        public static bool operator <=(uint64_t var1, ushort var2)      /* <= */
        {
            return (var1.var <= var2) ? true : false;
        }
        public static bool operator >=(uint64_t var1, ushort var2)      /* >= */
        {
            return (var1.var >= var2) ? true : false;
        }
        public static bool operator ==(uint64_t var1, ushort var2)      /* == */
        {
            return (var1.var == var2) ? true : false;
        }
        public static bool operator !=(uint64_t var1, ushort var2)      /* != */
        {
            return (var1.var != var2) ? true : false;
        }
        #endregion
        #region int
        /* Assignment */
        public static implicit operator int(uint64_t obj)
        {
            return (int)obj.var;
        }

        public static implicit operator uint64_t(int var)
        {
            return new uint64_t(var);
        }

        /* Math */
        public static uint64_t operator +(uint64_t var1, int var2)      /* + */
        {
            return new uint64_t(var1.var + (uint)var2);
        }
        public static uint64_t operator -(uint64_t var1, int var2)      /* - */
        {
            return new uint64_t(var1.var - (uint)var2);
        }
        public static uint64_t operator *(uint64_t var1, int var2)      /* * */
        {
            return new uint64_t(var1.var * (uint)var2);
        }
        public static uint64_t operator /(uint64_t var1, int var2)      /* / */
        {
            return new uint64_t(var1.var / (uint)var2);
        }
        public static uint64_t operator %(uint64_t var1, int var2)      /* % */
        {
            return new uint64_t(var1.var % (uint)var2);
        }
        public static uint64_t operator &(uint64_t var1, int var2)      /* & */
        {
            return new uint64_t(var1.var & (uint)var2);
        }
        public static uint64_t operator |(uint64_t var1, int var2)      /* | */
        {
            return new uint64_t(var1.var | (uint)var2);
        }
        public static uint64_t operator ^(uint64_t var1, int var2)      /* ^ */
        {
            return new uint64_t(var1.var ^ (uint)var2);
        }
        public static uint64_t operator >>(uint64_t var1, int var2)     /* >> */
        {
            return new uint64_t(var1.var >> var2);
        }
        public static uint64_t operator <<(uint64_t var1, int var2)     /* << */
        {
            return new uint64_t(var1.var << var2);
        }

        /* Comparison */
        public static bool operator >(uint64_t var1, int var2)          /* > */
        {
            return (var1.var > (uint)var2) ? true : false;
        }
        public static bool operator <(uint64_t var1, int var2)          /* < */
        {
            return (var1.var < (uint)var2) ? true : false;
        }
        public static bool operator <=(uint64_t var1, int var2)         /* <= */
        {
            return (var1.var <= (uint)var2) ? true : false;
        }
        public static bool operator >=(uint64_t var1, int var2)         /* >= */
        {
            return (var1.var >= (uint)var2) ? true : false;
        }
        public static bool operator ==(uint64_t var1, int var2)         /* == */
        {
            return (var1.var == (uint)var2) ? true : false;
        }
        public static bool operator !=(uint64_t var1, int var2)         /* != */
        {
            return (var1.var != (uint)var2) ? true : false;
        }
        #endregion
        #region uint
        /* Assignment */
        public static implicit operator uint(uint64_t obj)
        {
            return (uint)obj.var;
        }

        public static implicit operator uint64_t(uint var)
        {
            return new uint64_t(var);
        }

        /* Math */
        public static uint64_t operator +(uint64_t var1, uint var2)     /* + */
        {
            return new uint64_t(var1.var + var2);
        }
        public static uint64_t operator -(uint64_t var1, uint var2)     /* - */
        {
            return new uint64_t(var1.var - var2);
        }
        public static uint64_t operator *(uint64_t var1, uint var2)     /* * */
        {
            return new uint64_t(var1.var * var2);
        }
        public static uint64_t operator /(uint64_t var1, uint var2)     /* / */
        {
            return new uint64_t(var1.var / var2);
        }
        public static uint64_t operator %(uint64_t var1, uint var2)     /* % */
        {
            return new uint64_t(var1.var % var2);
        }
        public static uint64_t operator &(uint64_t var1, uint var2)     /* & */
        {
            return new uint64_t(var1.var & var2);
        }
        public static uint64_t operator |(uint64_t var1, uint var2)     /* | */
        {
            return new uint64_t(var1.var | var2);
        }
        public static uint64_t operator ^(uint64_t var1, uint var2)     /* != */
        {
            return new uint64_t(var1.var ^ var2);
        }

        /* Comparison */
        public static bool operator >(uint64_t var1, uint var2)         /* > */
        {
            return (var1.var > var2) ? true : false;
        }
        public static bool operator <(uint64_t var1, uint var2)         /* < */
        {
            return (var1.var < var2) ? true : false;
        }
        public static bool operator <=(uint64_t var1, uint var2)        /* <= */
        {
            return (var1.var <= var2) ? true : false;
        }
        public static bool operator >=(uint64_t var1, uint var2)        /* >= */
        {
            return (var1.var >= var2) ? true : false;
        }
        public static bool operator ==(uint64_t var1, uint var2)        /* == */
        {
            return (var1.var == var2) ? true : false;
        }
        public static bool operator !=(uint64_t var1, uint var2)        /* != */
        {
            return (var1.var != var2) ? true : false;
        }
        #endregion
        #region long
        /* Assignment */
        public static implicit operator long(uint64_t obj)
        {
            return (long)obj.var;
        }

        public static implicit operator uint64_t(long var)
        {
            return new uint64_t(var);
        }

        /* Math */
        public static uint64_t operator +(uint64_t var1, long var2)     /* + */
        {
            return new uint64_t(var1.var + (ulong)var2);
        }
        public static uint64_t operator -(uint64_t var1, long var2)     /* - */
        {
            return new uint64_t(var1.var - (ulong)var2);
        }
        public static uint64_t operator *(uint64_t var1, long var2)     /* * */
        {
            return new uint64_t(var1.var * (ulong)var2);
        }
        public static uint64_t operator /(uint64_t var1, long var2)     /* / */
        {
            return new uint64_t(var1.var / (ulong)var2);
        }
        public static uint64_t operator %(uint64_t var1, long var2)     /* % */
        {
            return new uint64_t(var1.var % (ulong)var2);
        }
        public static uint64_t operator &(uint64_t var1, long var2)     /* & */
        {
            return new uint64_t(var1.var & (ulong)var2);
        }
        public static uint64_t operator |(uint64_t var1, long var2)     /* | */
        {
            return new uint64_t(var1.var | (ulong)var2);
        }
        public static uint64_t operator ^(uint64_t var1, long var2)     /* != */
        {
            return new uint64_t(var1.var ^ (ulong)var2);
        }

        /* Comparison */
        public static bool operator >(uint64_t var1, long var2)         /* > */
        {
            return (var1.var > (ulong)var2) ? true : false;
        }
        public static bool operator <(uint64_t var1, long var2)         /* < */
        {
            return (var1.var < (ulong)var2) ? true : false;
        }
        public static bool operator <=(uint64_t var1, long var2)        /* <= */
        {
            return (var1.var <= (ulong)var2) ? true : false;
        }
        public static bool operator >=(uint64_t var1, long var2)        /* >= */
        {
            return (var1.var >= (ulong)var2) ? true : false;
        }
        public static bool operator ==(uint64_t var1, long var2)        /* == */
        {
            return (var1.var == (ulong)var2) ? true : false;
        }
        public static bool operator !=(uint64_t var1, long var2)        /* != */
        {
            return (var1.var != (ulong)var2) ? true : false;
        }
        #endregion
        #region ulong
        /* Assignment */
        public static implicit operator ulong(uint64_t obj)
        {
            return (ulong)obj.var;
        }

        public static implicit operator uint64_t(ulong var)
        {
            return new uint64_t(var);
        }

        /* Math */
        public static uint64_t operator +(uint64_t var1, ulong var2)    /* + */
        {
            return new uint64_t(var1.var + var2);
        }
        public static uint64_t operator -(uint64_t var1, ulong var2)    /* - */
        {
            return new uint64_t(var1.var - var2);
        }
        public static uint64_t operator *(uint64_t var1, ulong var2)    /* * */
        {
            return new uint64_t(var1.var * var2);
        }
        public static uint64_t operator /(uint64_t var1, ulong var2)    /* / */
        {
            return new uint64_t(var1.var / var2);
        }
        public static uint64_t operator %(uint64_t var1, ulong var2)    /* % */
        {
            return new uint64_t(var1.var % var2);
        }
        public static uint64_t operator &(uint64_t var1, ulong var2)    /* & */
        {
            return new uint64_t(var1.var & var2);
        }
        public static uint64_t operator |(uint64_t var1, ulong var2)    /* | */
        {
            return new uint64_t(var1.var | var2);
        }
        public static uint64_t operator ^(uint64_t var1, ulong var2)    /* != */
        {
            return new uint64_t(var1.var ^ var2);
        }

        /* Comparison */
        public static bool operator >(uint64_t var1, ulong var2)        /* > */
        {
            return (var1.var > var2) ? true : false;
        }
        public static bool operator <(uint64_t var1, ulong var2)        /* < */
        {
            return (var1.var < var2) ? true : false;
        }
        public static bool operator <=(uint64_t var1, ulong var2)       /* <= */
        {
            return (var1.var <= var2) ? true : false;
        }
        public static bool operator >=(uint64_t var1, ulong var2)       /* >= */
        {
            return (var1.var >= var2) ? true : false;
        }
        public static bool operator ==(uint64_t var1, ulong var2)       /* == */
        {
            return (var1.var == var2) ? true : false;
        }
        public static bool operator !=(uint64_t var1, ulong var2)       /* != */
        {
            return (var1.var != var2) ? true : false;
        }
        #endregion

        #region float
        /* Math */
        public static uint64_t operator +(uint64_t var1, float var2)    /* + */
        {
            return new uint64_t(var1.var + var2);
        }
        public static uint64_t operator -(uint64_t var1, float var2)    /* - */
        {
            return new uint64_t(var1.var - var2);
        }
        public static uint64_t operator *(uint64_t var1, float var2)    /* * */
        {
            return new uint64_t(var1.var * var2);
        }
        public static uint64_t operator /(uint64_t var1, float var2)    /* / */
        {
            return new uint64_t(var1.var / var2);
        }
        public static uint64_t operator %(uint64_t var1, float var2)    /* % */
        {
            return new uint64_t(var1.var % var2);
        }
        public static uint64_t operator &(uint64_t var1, float var2)    /* & */
        {
            throw new System.ArgumentException(System.String.Format("& operator cannot be applied with float parameter {0}", var2));
        }
        public static uint64_t operator |(uint64_t var1, float var2)    /* | */
        {
            throw new System.ArgumentException(System.String.Format("| operator cannot be applied with float parameter {0}", var2));
        }
        public static uint64_t operator ^(uint64_t var1, float var2)    /* != */
        {
            throw new System.ArgumentException(System.String.Format("^ operator cannot be applied with float parameter {0}", var2));
        }

        /* Comparison */
        public static bool operator >(uint64_t var1, float var2)        /* > */
        {
            return (var1.var > var2) ? true : false;
        }
        public static bool operator <(uint64_t var1, float var2)        /* < */
        {
            return (var1.var < var2) ? true : false;
        }
        public static bool operator <=(uint64_t var1, float var2)       /* <= */
        {
            return (var1.var <= var2) ? true : false;
        }
        public static bool operator >=(uint64_t var1, float var2)       /* >= */
        {
            return (var1.var >= var2) ? true : false;
        }
        public static bool operator ==(uint64_t var1, float var2)       /* == */
        {
            return (var1.var == var2) ? true : false;
        }
        public static bool operator !=(uint64_t var1, float var2)       /* != */
        {
            return (var1.var != var2) ? true : false;
        }
        #endregion
        #region double
        /* Math */
        public static uint64_t operator +(uint64_t var1, double var2)   /* + */
        {
            return new uint64_t(var1.var + var2);
        }
        public static uint64_t operator -(uint64_t var1, double var2)   /* - */
        {
            return new uint64_t(var1.var - var2);
        }
        public static uint64_t operator *(uint64_t var1, double var2)   /* * */
        {
            return new uint64_t(var1.var * var2);
        }
        public static uint64_t operator /(uint64_t var1, double var2)   /* / */
        {
            return new uint64_t(var1.var / var2);
        }
        public static uint64_t operator %(uint64_t var1, double var2)   /* % */
        {
            return new uint64_t(var1.var % var2);
        }
        public static uint64_t operator &(uint64_t var1, double var2)   /* & */
        {
            throw new System.ArgumentException(System.String.Format("& operator cannot be applied with double parameter {0}", var2));
        }
        public static uint64_t operator |(uint64_t var1, double var2)   /* | */
        {
            throw new System.ArgumentException(System.String.Format("| operator cannot be applied with double parameter {0}", var2));
        }
        public static uint64_t operator ^(uint64_t var1, double var2)   /* != */
        {
            throw new System.ArgumentException(System.String.Format("^ operator cannot be applied with double parameter {0}", var2));
        }

        /* Comparison */
        public static bool operator >(uint64_t var1, double var2)       /* > */
        {
            return (var1.var > var2) ? true : false;
        }
        public static bool operator <(uint64_t var1, double var2)       /* < */
        {
            return (var1.var < var2) ? true : false;
        }
        public static bool operator <=(uint64_t var1, double var2)      /* <= */
        {
            return (var1.var <= var2) ? true : false;
        }
        public static bool operator >=(uint64_t var1, double var2)      /* >= */
        {
            return (var1.var >= var2) ? true : false;
        }
        public static bool operator ==(uint64_t var1, double var2)      /* == */
        {
            return (var1.var == var2) ? true : false;
        }
        public static bool operator !=(uint64_t var1, double var2)      /* != */
        {
            return (var1.var != var2) ? true : false;
        }
        #endregion
        #endregion
        #endregion

        #region specials
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        public override string ToString()
        {
            return var.ToString();
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public uint64_t Increment()
        {
            this.var++;
            return this;
        }
        public uint64_t Decrement()
        {
            this.var--;
            return this;
        }
        #endregion
    }
}