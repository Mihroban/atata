﻿namespace Atata.Tests.Components
{
    using _ = DragAndDropPage;

    [Url("DragAndDrop.html")]
    public class DragAndDropPage : Page<_>
    {
        [FindById]
        public ItemsControl<DragItem, _> DropContainer { get; private set; }

        [FindById]
        public ItemsControl<DragItem, _> DragItems { get; private set; }

        [ControlDefinition("span", ContainingClass = "drag-item")]
        public class DragItem : Control<_>
        {
        }
    }
}
