using Demo_EposCmd.Properties;
using EposCmd.Net;
using EposCmd.Net.DeviceCmdSet.Operation;
using System;
using System.Windows.Forms;

namespace Demo_EposCmd
{
    public partial class Form1 : Form
    {
        #region Private fields

        private DeviceManager _connector;
        private Device _epos;
        private Device _epos2;
        private Device _epos3;
        private Device _epos4;

        Boolean enableGrasp = false;

        float result_angle = 0.0f;
        int limit_current = 0;

        #endregion

        /// <summary>
        /// Initializes a new instance of the <see cref="Form1"/> class.
        /// </summary>
        public Form1()
        {
            InitializeComponent();

            this.FormClosing += Form1_FormClosing;
        }

        /// <summary>
        /// Handles the Load event of the Form1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void Form1_Load(object sender, EventArgs e)
        {
            radioButtonRelativeMode.Checked = true;
            timer1.Interval = 500;
            timer1.Enabled = false;
        }

        /// <summary>
        /// Handles the FormClosing event of the Form1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="FormClosingEventArgs"/> instance containing the event data.</param>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopRefresh();

            if (_connector != null)
            {
                /*
                 * Important notice:
                 * It's recommended to call the Dispose function before application close
                 */
                _connector.Dispose();
            }
        }

        /// <summary>
        /// Handles the Tick event of the timer1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="ea">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void TimerTick(object sender, EventArgs ea)
        {
            try
            {
                if (_epos != null)
                {
                    textBoxPositionActualValue.Text = string.Format("{0}", _epos.Operation.MotionInfo.GetPositionIs());

                    tb_motor1.Text = string.Format("{0}", _epos.Operation.MotionInfo.GetPositionIs());
                    tb_motor2.Text = string.Format("{0}", _epos2.Operation.MotionInfo.GetPositionIs());
                    tb_motor3.Text = string.Format("{0}", _epos3.Operation.MotionInfo.GetPositionIs());
                    tb_motor4.Text = string.Format("{0}", _epos4.Operation.MotionInfo.GetPositionIs());

                    //float result_angle = 0.0f;

                    try
                    {
                        float temp_angle = Convert.ToInt32(textBoxTargetPosition.Text);
                        float fine_angle = Convert.ToInt32(hs_fine.Value) * 0.1f;

                        result_angle = temp_angle + fine_angle;
                        limit_current = Convert.ToInt32(tb_limitcurrent.Text);
                    }
                    catch (Exception e)
                    {

                    }

                    

                    tb_final_angle.Text = string.Format("{0}", result_angle);

                    if (_epos.Operation.StateMachine.GetEnableState())
                    {
                        buttonSettings.Enabled = false;
                        buttonEnable.Enabled = false;
                        buttonDisable.Enabled = true;
                        buttonMove.Enabled = true;
                        buttonHalt.Enabled = true;
                    }
                    else
                    {
                        buttonSettings.Enabled = true;
                        buttonEnable.Enabled = true;
                        buttonDisable.Enabled = false;
                        buttonMove.Enabled = false;
                        buttonHalt.Enabled = false;
                    }
                }
            }
            catch (DeviceException e)
            {
                StopRefresh();
                ShowMessageBox(e.ErrorMessage, e.ErrorCode);
            }
            catch (Exception e)
            {
                StopRefresh();

                MessageBox.Show(e.Message);
            }
        }

        /// <summary>
        /// Handles the Click event of the buttonExit control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void ButtonExitClick(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Handles the Click event of the buttonSettings control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="ea">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void ButtonSettingsClick(object sender, EventArgs ea)
        {
            try
            {
                _connector = new DeviceManager("EPOS2", "MAXON SERIAL V2", "USB", "USB0");


                _connector.Baudrate = 1000000;
                _connector.Timeout = 500;

                //// Get baudrate info
                //uint b = _connector.Baudrate;

                //// Set connection properties
                //_connector.Baudrate = b;
                //_connector.Timeout = 500;

                buttonEnable.Enabled = true;
            }
            catch (DeviceException e)
            {
                StopRefresh();
                ShowMessageBox(e.ErrorMessage, e.ErrorCode);
            }
            catch (Exception e)
            {
                StopRefresh();

                MessageBox.Show(e.Message);
            }
        }

        /// <summary>
        /// Handles the Click event of the buttonEnable control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="ea">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void ButtonEnableClick(object sender, EventArgs ea)
        {
            try
            {
                _epos = _connector.CreateDevice(Convert.ToUInt16(1));
                _epos2 = _connector.CreateSubDevice("EPOS2", "CANopen",2);
                _epos3 = _connector.CreateSubDevice("EPOS2", "CANopen", 3);
                _epos4 = _connector.CreateSubDevice("EPOS2", "CANopen", 4);

                textBoxAOM.Text = _epos.Operation.OperationMode.GetOperationModeAsString();

                StateMachine sm1 = _epos.Operation.StateMachine;
                StateMachine sm2 = _epos2.Operation.StateMachine;
                StateMachine sm3 = _epos3.Operation.StateMachine;
                StateMachine sm4 = _epos4.Operation.StateMachine;

                if (sm1.GetFaultState())
                {
                    sm1.ClearFault();
                }


                sm1.SetEnableState();

                buttonSettings.Enabled = false;
                buttonEnable.Enabled = false;
                buttonDisable.Enabled = true;
                buttonMove.Enabled = true;
                buttonHalt.Enabled = true;
                bt_home.Enabled = true;

                timer1.Enabled = true;
                timer1.Interval = 100;
            }
            catch (DeviceException e)
            {
                StopRefresh();
                ShowMessageBox(e.ErrorMessage, e.ErrorCode);
            }
            catch (Exception e)
            {
                StopRefresh();

                MessageBox.Show(e.Message);
            }
        }

        /// <summary>
        /// Handles the Click event of the buttonDisable control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="ea">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void ButtonDisableClick(object sender, EventArgs ea)
        {
            try
            {
                StateMachine sm1 = _epos.Operation.StateMachine;
                StateMachine sm2 = _epos2.Operation.StateMachine;
                StateMachine sm3 = _epos3.Operation.StateMachine;
                StateMachine sm4 = _epos4.Operation.StateMachine;

                if (sm1.GetFaultState())
                {
                    sm1.ClearFault();
                    sm2.ClearFault();
                    sm3.ClearFault();
                    sm4.ClearFault();
                }

                if (!sm1.GetDisableState())
                {
                    sm1.SetDisableState();
                    sm2.SetDisableState();
                    sm3.SetDisableState();
                    sm4.SetDisableState();
                }

                buttonSettings.Enabled = true;
                buttonEnable.Enabled = true;
                buttonDisable.Enabled = false;
                buttonMove.Enabled = false;
                buttonHalt.Enabled = false;
                bt_home.Enabled = false;
            }
            catch (DeviceException e)
            {
                StopRefresh();
                ShowMessageBox(e.ErrorMessage, e.ErrorCode);
            }
            catch (Exception e)
            {
                StopRefresh();

                MessageBox.Show(e.Message);
            }
        }

        /// <summary>
        /// Handles the Click event of the buttonMove control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="ea">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void ButtonMoveClick(object sender, EventArgs ea)
        {
            try
            {
                //지금 작동 안되는 이유 1. qpos 설정이 잘못됨! 2. 모터 4개인데 1개만 움직임....
                //


                ProfilePositionMode ppm = _epos.Operation.ProfilePositionMode;

                ppm.ActivateProfilePositionMode();

                textBoxAOM.Text = _epos.Operation.OperationMode.GetOperationModeAsString();

                textBoxPositionStart.Text = string.Format("{0}", _epos.Operation.MotionInfo.GetPositionIs());

                ppm.MoveToPosition(Convert.ToInt32(textBoxTargetPosition.Text), radioButtonAbsoluteMove.Checked, true);
                ppm.
            }
            catch (DeviceException e)
            {
                StopRefresh();
                ShowMessageBox(e.ErrorMessage, e.ErrorCode);
            }
            catch (OverflowException e)
            {
                MessageBox.Show(e.Message);
            }
            catch (FormatException e)
            {
                MessageBox.Show(e.Message);
            }
            catch (Exception e)
            {
                StopRefresh();

                MessageBox.Show(e.Message);
            }
        }

        /// <summary>
        /// Handles the Click event of the buttonHalt control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="ea">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void ButtonHaltClick(object sender, EventArgs ea)
        {
            try
            {
                ProfilePositionMode ppm = _epos.Operation.ProfilePositionMode;

                ppm.ActivateProfilePositionMode();

                textBoxAOM.Text = _epos.Operation.OperationMode.GetOperationModeAsString();

                ppm.HaltPositionMovement();
            }
            catch (DeviceException e)
            {
                StopRefresh();
                ShowMessageBox(e.ErrorMessage, e.ErrorCode);
            }
            catch (Exception e)
            {
                StopRefresh();

                MessageBox.Show(e.Message);
            }
        }

        /// <summary>
        /// Stops the refresh.
        /// </summary>
        private void StopRefresh()
        {
            try
            {
                timer1.Enabled = false;

                buttonSettings.Enabled = true;
                buttonEnable.Enabled = false;
                buttonDisable.Enabled = false;
                buttonMove.Enabled = false;
                buttonHalt.Enabled = false;

                _epos = null;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Shows Error Message
        /// </summary>
        /// <param name="text">The text.</param>
        /// <param name="errorCode">The error code.</param>
        private void ShowMessageBox(string text, uint errorCode)
        {
            var msg = string.Format("{0}\nErrorCode: {1:X8}", text, errorCode);

            MessageBox.Show(msg, Resources.Caption_Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void buttonGrasp_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            _epos.Operation.HomingMode.ActivateHomingMode();
            _epos2.Operation.HomingMode.ActivateHomingMode();
            _epos3.Operation.HomingMode.ActivateHomingMode();
            _epos4.Operation.HomingMode.ActivateHomingMode();

            _epos.Operation.StateMachine.SetEnableState();
            _epos2.Operation.StateMachine.SetEnableState();
            _epos3.Operation.StateMachine.SetEnableState();
            _epos4.Operation.StateMachine.SetEnableState();

            _epos.Operation.HomingMode.SetHomingParameter(700, 1000, 10, 0, 230, 0);
            _epos2.Operation.HomingMode.SetHomingParameter(700, 1000, 10, 0, 230, 0);
            _epos3.Operation.HomingMode.SetHomingParameter(700, 1000, 10, 0, 230, 0);
            _epos4.Operation.HomingMode.SetHomingParameter(700, 1000, 10, 0, 230, 0);

            _epos.Operation.HomingMode.FindHome(EHomingMethod.HmCurrentThresholdPositiveSpeed);
            _epos2.Operation.HomingMode.FindHome(EHomingMethod.HmCurrentThresholdPositiveSpeed);
            _epos3.Operation.HomingMode.FindHome(EHomingMethod.HmCurrentThresholdPositiveSpeed);
            _epos4.Operation.HomingMode.FindHome(EHomingMethod.HmCurrentThresholdPositiveSpeed);
        }
    }
}
