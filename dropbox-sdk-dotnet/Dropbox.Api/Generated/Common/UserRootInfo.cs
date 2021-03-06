// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Common
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>Root info when user is not member of a CDM team.</para>
    /// </summary>
    /// <seealso cref="Global::Dropbox.Api.Common.RootInfo" />
    public class UserRootInfo : RootInfo
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<UserRootInfo> Encoder = new UserRootInfoEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<UserRootInfo> Decoder = new UserRootInfoDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="UserRootInfo" /> class.</para>
        /// </summary>
        /// <param name="rootNamespaceId">The namespace id for user's root namespace. It will
        /// be the namespace id of the shared team root if the user is member of a CDM team.
        /// Otherwise it will be same as <see
        /// cref="Dropbox.Api.Common.RootInfo.HomeNamespaceId" />.</param>
        /// <param name="homeNamespaceId">The namespace id for user's home namespace.</param>
        public UserRootInfo(string rootNamespaceId,
                            string homeNamespaceId)
            : base(rootNamespaceId, homeNamespaceId)
        {
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="UserRootInfo" /> class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public UserRootInfo()
        {
        }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="UserRootInfo" />.</para>
        /// </summary>
        private class UserRootInfoEncoder : enc.StructEncoder<UserRootInfo>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(UserRootInfo value, enc.IJsonWriter writer)
            {
                WriteProperty("root_namespace_id", value.RootNamespaceId, writer, enc.StringEncoder.Instance);
                WriteProperty("home_namespace_id", value.HomeNamespaceId, writer, enc.StringEncoder.Instance);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="UserRootInfo" />.</para>
        /// </summary>
        private class UserRootInfoDecoder : enc.StructDecoder<UserRootInfo>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="UserRootInfo" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override UserRootInfo Create()
            {
                return new UserRootInfo();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(UserRootInfo value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "root_namespace_id":
                        value.RootNamespaceId = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "home_namespace_id":
                        value.HomeNamespaceId = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    default:
                        reader.Skip();
                        break;
                }
            }
        }

        #endregion
    }
}
