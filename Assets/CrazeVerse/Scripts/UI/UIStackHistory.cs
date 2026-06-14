using System.Collections.Generic;

namespace CrazeVerse.UI
{
    public class UIStackHistory
    {
        private readonly Stack<ScreenId> history = new Stack<ScreenId>();

        public void Push(ScreenId screenId)
        {
            history.Push(screenId);
        }

        public ScreenId Pop()
        {
            if (!CanGoBack())
            {
                return ScreenId.HomeLobby;
            }

            return history.Pop();
        }

        public void Clear()
        {
            history.Clear();
        }

        public bool CanGoBack()
        {
            return history.Count > 0;
        }
    }
}
