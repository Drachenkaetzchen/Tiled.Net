﻿using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Tiled
{
    /// <summary>
    /// Represents a layer that holds tiles (<see cref="TiledTile"/>).
    /// </summary>
    public class TiledTileLayer : TiledBaseLayer
    {
        /// <summary>
        /// The x-coordinate of the layer in tiles.
        /// </summary>
        /// <remarks>Defaults to 0 and can no longer be changed in Tiled Qt.</remarks>
        [XmlAttribute("x")]
        public int X;

        /// <summary>
        /// The y-coordinate of the layer in tiles.
        /// </summary>
        /// <remarks>Defaults to 0 and can no longer be changed in Tiled Qt.</remarks>
        [XmlAttribute("y")]
        public int Y;

        /// <summary>
        /// The opacity of the layer from 0-1.
        /// </summary>
        [XmlAttribute("opacity")]
        public float Opacity = 1;

        /// <summary>
        /// Whether the layer is shown (1) or hidden (0).
        /// </summary>
        [XmlAttribute("visible")]
        public int Visible = 1;

        /// <summary>
        /// The rendering x-offset for this layer in pixels.
        /// </summary>
        [XmlAttribute("offsetx")]
        public int OffsetX;

        /// <summary>
        /// The rendering y-offset for this layer in pixels.
        /// </summary>
        [XmlAttribute("offsety")]
        public int OffsetY;

        /// <summary>
        /// Custom properties for the layer. These are arbitrary and are meant for the user.
        /// </summary>
        [XmlArray("properties")]
        [XmlArrayItem("property")]
        public List<TiledProperty> Properties;

        /// <summary>
        /// The layer's tile data.
        /// </summary>
        [XmlElement("data")]
        public TiledData Data;

        /// <summary>
        /// Nothing to see here. Used for serialization.
        /// </summary>
        /// <returns></returns>
        public bool ShouldSerializeX()
        {
            return X != 0;
        }

        /// <summary>
        /// Nothing to see here. Used for serialization.
        /// </summary>
        /// <returns></returns>
        public bool ShouldSerializeY()
        {
            return Y != 0;
        }

        /// <summary>
        /// Nothing to see here. Used for serialization.
        /// </summary>
        /// <returns></returns>
        public bool ShouldSerializeOpacity()
        {
            return Math.Abs(Opacity - 1f) > float.Epsilon;
        }

        /// <summary>
        /// Nothing to see here. Used for serialization.
        /// </summary>
        /// <returns></returns>
        public bool ShouldSerializeVisible()
        {
            return Visible == 0;
        }

        /// <summary>
        /// Nothing to see here. Used for serialization.
        /// </summary>
        /// <returns></returns>
        public bool ShouldSerializeOffsetX()
        {
            return OffsetX > 0;
        }

        /// <summary>
        /// Nothing to see here. Used for serialization.
        /// </summary>
        /// <returns></returns>
        public bool ShouldSerializeOffsetY()
        {
            return OffsetY > 0;
        }

        /// <summary>
        /// Nothing to see here. Used for serialization.
        /// </summary>
        /// <returns></returns>
        public bool ShouldSerializeProperties()
        {
            return Properties != null && Properties.Count > 0;
        }

        /// <summary>
        /// Nothing to see here. Used for serialization.
        /// </summary>
        /// <returns></returns>
        public bool ShouldSerializeData()
        {
            return Data != null;
        }
    }
}
