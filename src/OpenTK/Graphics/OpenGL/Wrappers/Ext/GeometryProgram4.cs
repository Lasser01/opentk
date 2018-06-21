//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2015 Stefanos Apostolopoulos for the Open Toolkit Library
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights to
// use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
// the Software, and to permit persons to whom the Software is furnished to do
// so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
//

using System;
using System.Text;
using System.Runtime.InteropServices;

namespace OpenTK.Graphics.OpenGL
{
    public sealed partial class GL
    {
        /// <summary>
        /// Contains native bindings to functions in the category "GeometryProgram4" in the extension "Ext".
        /// </summary>
        public static partial class Ext
        {
            /// <summary>
            /// [requires: NV_geometry_program4]
            /// Attach a level of a texture object as a logical buffer to the currently bound framebuffer object
            /// </summary>
            /// <param name="target">
            /// Specifies the framebuffer target. target must be DrawFramebuffer, ReadFramebuffer, or Framebuffer. Framebuffer is equivalent to DrawFramebuffer.
            /// </param>
            /// <param name="attachment">
            /// Specifies the attachment point of the framebuffer. attachment must be ColorAttachmenti, DepthAttachment, StencilAttachment or DepthStencilAttachment.
            /// </param>
            /// <param name="texture">
            /// Specifies the texture object to attach to the framebuffer attachment point named by attachment.
            /// </param>
            /// <param name="level">
            /// Specifies the mipmap level of texture to attach.
            /// </param>
            [AutoGenerated(Category = "NV_geometry_program4", Version = "", EntryPoint = "glFramebufferTextureEXT")]
            public static void FramebufferTexture(OpenTK.Graphics.OpenGL.FramebufferTarget target, OpenTK.Graphics.OpenGL.FramebufferAttachment attachment, uint texture, int level)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: NV_geometry_program4]
            /// </summary>
            /// <param name="target">
            /// </param>
            /// <param name="attachment">
            /// </param>
            /// <param name="texture">
            /// </param>
            /// <param name="level">
            /// </param>
            /// <param name="face">
            /// </param>
            [AutoGenerated(Category = "NV_geometry_program4", Version = "", EntryPoint = "glFramebufferTextureFaceEXT")]
            public static void FramebufferTextureFace(OpenTK.Graphics.OpenGL.FramebufferTarget target, OpenTK.Graphics.OpenGL.FramebufferAttachment attachment, uint texture, int level, OpenTK.Graphics.OpenGL.TextureTarget face)
            {
                throw new BindingsNotRewrittenException();
            }

            [Slot(644)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glFramebufferTextureEXT(OpenTK.Graphics.OpenGL.FramebufferTarget target, OpenTK.Graphics.OpenGL.FramebufferAttachment attachment, uint texture, int level);

            [Slot(646)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glFramebufferTextureFaceEXT(OpenTK.Graphics.OpenGL.FramebufferTarget target, OpenTK.Graphics.OpenGL.FramebufferAttachment attachment, uint texture, int level, OpenTK.Graphics.OpenGL.TextureTarget face);
        }
    }
}