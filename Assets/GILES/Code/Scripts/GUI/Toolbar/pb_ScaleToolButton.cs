﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

namespace GILES
{
	public class pb_ScaleToolButton : pb_ToolbarButton
	{
		public override string tooltip { get { return "Scale Tool"; } }

		protected override void Start()
		{
			base.Start();

			if(pb_SelectionHandle.instance.onHandleTypeChanged != null)
				pb_SelectionHandle.instance.onHandleTypeChanged += OnHandleChange;
			else
				pb_SelectionHandle.instance.onHandleTypeChanged = OnHandleChange;

			OnHandleChange();
		}

		public void DoSetHandle()
		{
			pb_SelectionHandle.instance.SetTool(Tool.Scale);
		}

		private void OnHandleChange()
		{
			interactable = !pb_SelectionHandle.instance.GetIsHidden() && pb_SelectionHandle.instance.GetTool() != Tool.Scale;
		}
	}
}