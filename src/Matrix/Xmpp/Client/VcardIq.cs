/*
 * Copyright (c) 2003-2017 by AG-Software <info@ag-software.de>
 *
 * All Rights Reserved.
 * See the COPYING file for more information.
 *
 * This file is part of the MatriX project.
 *
 * NOTICE: All information contained herein is, and remains the property
 * of AG-Software and its suppliers, if any.
 * The intellectual and technical concepts contained herein are proprietary
 * to AG-Software and its suppliers and may be covered by German and Foreign Patents,
 * patents in process, and are protected by trade secret or copyright law.
 *
 * Dissemination of this information or reproduction of this material
 * is strictly forbidden unless prior written permission is obtained
 * from AG-Software.
 *
 * Contact information for AG-Software is available at http://www.ag-software.de
 */

namespace Matrix.Xmpp.Client
{
    /// <summary>
    /// Vcard Iq
    /// </summary>
    public class VcardIq : Iq
    {
        #region << Constructors >>
        /// <summary>
        /// Initializes a new instance of the <see cref="VcardIq"/> class.
        /// </summary>
        public VcardIq()
        {
            GenerateId();
            Vcard = new Vcard.Vcard();
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="VcardIq"/> class.
        /// </summary>
        /// <param name="type">The type.</param>
        public VcardIq(IqType type)
            : this()
        {
            Type = type;
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="VcardIq"/> class.
        /// </summary>
        /// <param name="to">To Jid.</param>
        public VcardIq(Jid to)
            : this()
        {
            To = to;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VcardIq"/> class.
        /// </summary>
        /// <param name="to">To Jid.</param>
        /// <param name="from">From Jid.</param>
        public VcardIq(Jid to, Jid from)
            : this(to)
        {
            From = from;
        }        

        /// <summary>
        /// Initializes a new instance of the <see cref="VcardIq"/> class.
        /// </summary>
        /// <param name="to">To Jid.</param>
        /// <param name="from">From Jid.</param>
        /// <param name="type">The type.</param>
        public VcardIq(Jid to, Jid from, IqType type)
            : this(to, from)
        {
            Type = type;
        }       
        #endregion
        
        /// <summary>
        /// Gets or sets the vcard.
        /// </summary>
        /// <value>The vcard.</value>
        public Vcard.Vcard Vcard
        {
            get { return Element<Vcard.Vcard>(); }
            set { Replace(value); }
        }
    }
}
