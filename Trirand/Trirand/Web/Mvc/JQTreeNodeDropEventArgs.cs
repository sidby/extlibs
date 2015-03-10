namespace Trirand.Web.Mvc
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    public class JQTreeNodeDropEventArgs
    {
        public JQTreeNode DestinationNode { get; set; }

        public string DestinationTreeViewID { get; set; }

        public List<JQTreeNode> DraggedNodes { get; set; }

        public string SourceTreeViewID { get; set; }
    }
}

