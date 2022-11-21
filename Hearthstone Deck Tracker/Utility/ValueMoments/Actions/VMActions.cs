using System.Collections.Generic;

namespace Hearthstone_Deck_Tracker.Utility.ValueMoments.Actions
{
	public abstract class VMActions
	{
		public class InstallAction : VMAction
		{
			public const string Name = "first_app_start";

			public InstallAction(Dictionary<string, object> properties) : base(
				Name, Source.App, "First App Start", null, properties
			)
			{ }
		}

		public class FirstCollectionUploadAction : VMAction
		{
			public const string Name = "first_collection_upload";

			public FirstCollectionUploadAction(Dictionary<string, object> properties) : base(
				Name, Source.App, "First Collection Upload", null, properties
			)
			{ }
		}
		
		public class ToastAction : VMAction
		{
			public const string Name = "toast_click";

			public ToastAction(Dictionary<string, object> properties) : base(
				Name, Source.Overlay, "Toast Click", null, properties
			)
			{ }
		}

		public class ClickAction : VMAction
		{
			public const string Name = "Click Action HDT";

			public abstract class ActionName
			{
				public const string ScreenshotCopyToClipboard = "screenshot: Copy to Clipboard";
				public const string ScreenshotSaveToDisk = "screenshot: Save To Disk";
				public const string ScreenshotUploadToImgur = "screenshot: Upload to Imgur";

				public const string StatsArena = "stats: Constructed";
				public const string StatsConstructed = "stats: Arena";
			}

			public ClickAction(Dictionary<string, object> properties) : base(
				Name, Source.MainWindow, "Click Action", 10, properties
			)
			{ }
		}

		public class CopyDeckAction : VMAction
		{
			public const string Name = "Copy Deck HDT";

			public CopyDeckAction(Dictionary<string, object> properties) : base(
				Name, Source.MainWindow, "Copy Deck", 1, properties
			)
			{ }
		}

		public class EndMatchAction : VMAction
		{
			public const string Name = "End Match Action HDT";

			public EndMatchAction(Dictionary<string, object> properties) : base(
				Name, Source.App, "End Match Action", 20, properties
			)
			{ }
		}
	}
}
