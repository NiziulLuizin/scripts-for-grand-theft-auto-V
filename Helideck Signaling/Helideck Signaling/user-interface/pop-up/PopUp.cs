//using GTA;
//using GTA.UI;

//using System.Drawing;

//using System.Collections.Generic;

//using Helideck_Signaling.setup_manager;

//using Helideck_Signaling.user_interface.pop_up.settings;

//using Helideck_Signaling.user_interface.pop_up.settings.creators;


//namespace Helideck_Signaling.user_interface.pop_up
//{
//    internal sealed class PopUp : Script
//    {
//        public PopUp()
//        {
//            var layoutGroupManager =
//                new LayoutGroupManager();

//            var layoutsGroupTop =
//                layoutGroupManager
//                                .LayoutsTop;

//            var layoutsGroupBody =
//                layoutGroupManager
//                                .LayoutsBody;

//            var layoutsGroupBottom =
//                layoutGroupManager
//                                .LayoutsBottom;

//            var layoutsGroupTimer =
//                layoutGroupManager
//                                .LayoutsTimer;

//            layoutsGroupTop
//                .Add(new LayoutCreator(LayoutGroups
//                                                .TOP));

//            layoutsGroupBody
//                .Add(new LayoutCreator(LayoutGroups
//                                                .BODY));
//            layoutsGroupBody
//                .Add(new LayoutCreator(LayoutGroups
//                                                .BODY, true));
//            layoutsGroupBody
//                .Add(new LayoutCreator(LayoutGroups
//                                                .BODY, true));

//            layoutsGroupBottom
//                .Add(new LayoutCreator(LayoutGroups
//                                                .BOTTOM));

//            layoutsGroupTimer
//                .Add(new LayoutCreator(LayoutGroups
//                                                .TIMER));

//            layoutsGroupBody[0]
//                .DisableAllSprites();

//            layoutsGroupBody[0]
//                .EnableThis(spriteIndex: 0);

//            layoutsGroupBody[0]
//                .EnableThis(spriteIndex: 1);

//            layoutsGroupBody[0]
//                .EnableThis(spriteIndex: 3);

//            layoutsGroupBody[0]
//                .EnableThis(spriteIndex: 5);

//            layoutsGroupBody[0]
//                .EnableThis(spriteIndex: 7);

//            layoutsGroupBody[0]
//                .EnableThis(spriteIndex: 8);

//            Tick    += (o, e) =>
//            {
//                layoutGroupManager
//                    .ScaledDrawThis(layoutsGroupBottom);

//                layoutGroupManager
//                    .ScaledDrawThis(layoutsGroupBody);

//                layoutGroupManager
//                    .ScaledDrawThis(layoutsGroupTop);

//                layoutGroupManager
//                    .ScaledDrawThis(layoutsGroupTimer);
//            };

//            Aborted += (o, e) =>
//            {
//                layoutGroupManager
//                        .DisposeAll();
//            };

//            KeyUp   += (o, e) =>
//            {
//                switch (e.KeyCode)
//                {
//                    case System.Windows.Forms.Keys.I:
//                        {
//                            layoutsGroupTop[0]
//                                            .DisableAllSprites();
//                        }
//                        return;
//                    case System.Windows.Forms.Keys.U:
//                        {
//                            layoutsGroupTop[0]
//                                            .EnableAllSprites();
//                        }
//                        return;
//                    case System.Windows.Forms.Keys.Oemplus:
//                        {
//                            if (layoutsGroupBody.Count == 0)
//                            {
//                                layoutsGroupBody
//                                    .Add(new LayoutCreator(LayoutGroups
//                                                                    .BODY));
//                            }
//                            else
//                            {
//                                layoutsGroupBody
//                                    .Add(new LayoutCreator(LayoutGroups
//                                                                    .BODY, true));
//                            }
//                        }
//                        return;
//                    case System.Windows.Forms.Keys.OemMinus:
//                        {
//                            layoutsGroupBody
//                                .RemoveAt(layoutsGroupBody
//                                                        .Count - 1);
//                        }
//                        return;
//                    case System.Windows.Forms.Keys.Up:
//                        {
                            
//                        }
//                        return;
//                }
//            };
//        }
//    }
//}
