namespace FlexiSkills.Enums
{
	public struct NotificationMsg
	{
		public NotificationMsg(string Message, String Type)
		{
			this.Message = Message;
			this.Type = Type;
		}

		public String Message { get; set; }
		public String Type { get; set; }

		//public override string ToString() => $"({{Message: {this.Message}, Type: {this.Type}}})";

		//public override string ToString() => String.Format(" message = {0}, type = {1} ", this.Message, this.Type);
    }
}

