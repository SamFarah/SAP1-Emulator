/*************************************************************************************************
* 
* Title: Bit Field in C#
* Author: George Jonsson
* Date: 11 May 2016
* Code Revision: 2.0
* Availability: https://www.codeproject.com/Articles/1095576/Bit-Field-in-Csharp-using-struct
* 
*************************************************************************************************/

using System;
using System.Reflection;
using System.Text;

namespace BitField
{
    /// <summary>
    /// Interface used as a marker in order to create extension methods on a struct
    /// that is used to emulate bit fields
    /// </summary>
    public interface IBitField { }

    public static class BitFieldExtensions
    {
        /// <summary>
        /// Converts the members of the bit field to an integer value.
        /// </summary>
        /// <param name="obj">An instance of a struct that implements the interface IBitField.</param>
        /// <returns>An integer representation of the bit field.</returns>
        public static ulong ToUInt64(this IBitField obj)
        {
            ulong result = 0;

            // Loop through all the properties
            foreach (PropertyInfo pi in obj.GetType().GetProperties())
            {
                // Check if the property has an attribute of type BitFieldLengthAttribute
                BitFieldInfoAttribute bitField = (pi.GetCustomAttribute(typeof(BitFieldInfoAttribute)) as BitFieldInfoAttribute);
                if (bitField != null)
                {
                    // Calculate a bitmask using the length of the bit field
                    ulong mask = 0;
                    for (byte i = 0; i < bitField.Length; i++)
                        mask |= 1UL << i;

                    // This conversion makes it possible to use different types in the bit field
                    ulong value = Convert.ToUInt64(pi.GetValue(obj));

                    result |= (value & mask) << bitField.Offset;
                }
            }

            return result;
        }

        /// <summary>
        /// Creates a new instance of the provided struct.
        /// </summary>
        /// <typeparam name="T">The type of the struct that is to be created.</typeparam>
        /// <param name="value">The initial value of the struct.</param>
        /// <returns>The instance of the new struct.</returns>
        public static T CreateBitField<T>(ulong value) where T : struct
        {
            // The created struct has to be boxed, otherwise PropertyInfo.SetValue
            // will work on a copy instead of the actual object
            object boxedValue = new T();

            // Loop through the properties and set a value to each one
            foreach (PropertyInfo pi in boxedValue.GetType().GetProperties())
            {
                BitFieldInfoAttribute bitField = (pi.GetCustomAttribute(typeof(BitFieldInfoAttribute)) as BitFieldInfoAttribute);
                if (bitField != null)
                {
                    ulong mask = (ulong)Math.Pow(2, bitField.Length) - 1;
                    object setVal = Convert.ChangeType((value >> bitField.Offset) & mask, pi.PropertyType);
                    pi.SetValue(boxedValue, setVal);
                }
            }

            // Unboxing the object
            return (T)boxedValue;
        }

        /// <summary>
        /// This method converts the struct into a string of binary values.
        /// The length of the string will be equal to the number of bits in the struct
        /// The least significant bit will be on the right in the string.
        /// </summary>
        /// <param name="obj">An instance of a struct that implements the interface IBitField.</param>
        /// <returns>A string representing the binary value of tbe bit field.</returns>
        public static string ToBinaryString(this IBitField obj)
        {
            BitFieldNumberOfBitsAttribute bitField = (obj.GetType().GetCustomAttribute(typeof(BitFieldNumberOfBitsAttribute)) as BitFieldNumberOfBitsAttribute);
            if (bitField == null)
                throw new Exception(string.Format("The attribute 'BitFieldNumberOfBitsAttribute' has to be added to the struct '{0}'.", obj.GetType().Name));

            StringBuilder sb = new StringBuilder(bitField.BitCount);

            ulong bitFieldValue = obj.ToUInt64();
            for (int i = bitField.BitCount - 1; i >= 0; i--)
            {
                sb.Append(((bitFieldValue & (1UL << i)) > 0) ? "1" : "0");
            }

            return sb.ToString();
        }
    }
}
