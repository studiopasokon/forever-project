using System;

namespace StudioPasokon.ForeverProject.DataTypes
{
    /// <summary>
    /// Implementation of the non-null, non-empty and non-whitespace string type.
    /// </summary>
    public readonly struct MandatoryString
    {
        /// <summary>
        /// This field contains the real string data.
        /// </summary>
        private readonly string _internalString;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="value">The string value to store in the <see cref="MandatoryString"/> type.</param>
        public MandatoryString(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentNullException(nameof(value), "A mandatory string cannot be null, empty or fully whitespace");

            _internalString = value;
        }

        /// <inheritdoc />
        public override string ToString() => _internalString;

        /// <summary>
        /// Implicit conversion from a <see cref="MandatoryString"/> to an ordinary string.
        /// </summary>
        /// <param name="ms"><see cref="MandatoryString"/> value to convert.</param>
        public static implicit operator string(MandatoryString ms) => ms.ToString();

        /// <summary>
        /// Explicit conversion from a string to a <see cref="MandatoryString"/>.
        /// </summary>
        /// <param name="s">String value to convert.</param>
        public static explicit operator MandatoryString(string s) => new MandatoryString(s);
    }
}
