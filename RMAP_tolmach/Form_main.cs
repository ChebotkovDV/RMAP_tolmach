using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RMAP_tolmach
{
    public partial class Form_main : Form
    {
        
        private RmapPacket commandPacket;

        public Form_main()
        {
            InitializeComponent();

            this.consoleContextMenu.Items.AddRange(new[] { clearMenuItem, copyMenuItem });
            this.copyMenuItem.Click += CopyMenuItem_Click;
            this.clearMenuItem.Click += ClearMenuItem_Click;
            this.statusMenuItem.Click += StatusMenuItem_Click;

            commandPacket = new RmapPacket();
            UpdateAllFields();
        }

        private void ClearMenuItem_Click(object sender, EventArgs e)
        {
            textBox_Console.Clear();
        }

        private void StatusMenuItem_Click(object sender, EventArgs e)
        {
            Report(commandPacket.FieldsStatus);
        }

        private void CopyMenuItem_Click(object sender, EventArgs e)
        {
            // если выделен текст в текстовом поле, то копируем его в буфер
            Clipboard.SetText(textBox_Console.SelectedText);
        }


        // очистка консоли
        void clearMenuItem_Click(object sender, EventArgs e)
        {
            textBox_Console.Clear();
        }
        // копирование текста
        void copyMenuItem_Click(object sender, EventArgs e)
        {
            // если выделен текст в текстовом поле, то копируем его в буфер
            Clipboard.SetText(textBox_Console.SelectedText);
        }
        private void button_packetGenerate_Click(object sender, EventArgs e)
        {
            UpdateAllFields();

            textBox_packet.Text = commandPacket.GetRMAPPacket();
            Report("---  Создан новый пакет ---\r\n");
            Report(commandPacket.Status);
        }

        private void UpdateAllFields()
        {
            commandPacket.TargetSpWAddresses.Set(textBox_TargetSpWAddresses.Text);
            commandPacket.TargetLogicalAddresses.Set(textBox_TargetLogicalAddresses.Text);
            commandPacket.ProtocolIdentifier.Set(textBox_ProtocolIdentifier.Text);
            commandPacket.Instruction.Set(textBox_Instruction.Text);
            commandPacket.Key.Set(textBox_Key.Text);
            commandPacket.ReplyAddress.Set(textBox_ReplayAddresses.Text);
            commandPacket.InitiatorLogicalAddress.Set(textBox_InitiatorLogicalAddress.Text);
            commandPacket.TransactionIdentifier.Set(textBox_TransactionIdentifier.Text);
            commandPacket.ExtendedAddress.Set(textBox_extendedAddress.Text);
            commandPacket.Address.Set(textBox_address.Text);
            commandPacket.DataLength.Set(textBox_DataLength.Text);
            commandPacket.HeaderCRC.Set(textBox_headerCRC.Text);
            commandPacket.Data.Set(textBox_Data.Text);
            commandPacket.DataCRC.Set(textBox_dataCRC.Text);
            commandPacket.EEP = radioButton_Eep.Checked;

            if (commandPacket.Fail)
            {
                Report("одно или несколько полей заполнено не корректно");
            }
        }

        private void Report(string rep)
        {
            textBox_Console.AppendText(rep + "\r\n");

        }
        // обновление элементов управления полем "Instruction":
        private void InstructionControlsUpdate(object sender, EventArgs e)
        {
            commandPacket.Instruction.Set(textBox_Instruction.Text);

            // отписываем InstructionTextBoxUpdate от событий, чтобы не зациклиться:
            checkBox_commandCode_incAddress.CheckedChanged -= new System.EventHandler(this.InstructionTextBoxUpdate);
            checkBox_commandCode_rw.CheckedChanged -= new System.EventHandler(this.InstructionTextBoxUpdate);
            checkBox_commandCode_verify.CheckedChanged -= new System.EventHandler(this.InstructionTextBoxUpdate);
            checkBox_commandCode_reply.CheckedChanged -= new System.EventHandler(this.InstructionTextBoxUpdate);
            radioButton_packetType_reply.CheckedChanged -= new System.EventHandler(this.InstructionTextBoxUpdate);
            radioButton_packetType_command.CheckedChanged -= new System.EventHandler(this.InstructionTextBoxUpdate);
            radioButton_replyAddrLength_0.CheckedChanged -= new System.EventHandler(this.InstructionTextBoxUpdate);
            radioButton_replyAddrLength_4.CheckedChanged -= new System.EventHandler(this.InstructionTextBoxUpdate);
            radioButton_replyAddrLength_8.CheckedChanged -= new System.EventHandler(this.InstructionTextBoxUpdate);
            radioButton_replyAddrLength_12.CheckedChanged -= new System.EventHandler(this.InstructionTextBoxUpdate);
            // обновляем элементы управления
            checkBox_commandCode_rw.Checked = commandPacket.Instruction.CommandType.WriteRead;
            checkBox_commandCode_verify.Checked = commandPacket.Instruction.CommandType.VerifyDataBeforeWrite;
            checkBox_commandCode_reply.Checked = commandPacket.Instruction.CommandType.Reply;
            checkBox_commandCode_incAddress.Checked = commandPacket.Instruction.CommandType.IncrementAddress;
            radioButton_packetType_reply.Checked = commandPacket.Instruction.PacketType.Reply;
            radioButton_packetType_command.Checked = commandPacket.Instruction.PacketType.Command;
            radioButton_replyAddrLength_0.Checked = commandPacket.Instruction.AddressLength.ToInt() == 0;
            radioButton_replyAddrLength_4.Checked = commandPacket.Instruction.AddressLength.ToInt() == 4;
            radioButton_replyAddrLength_8.Checked = commandPacket.Instruction.AddressLength.ToInt() == 8;
            radioButton_replyAddrLength_12.Checked = commandPacket.Instruction.AddressLength.ToInt() == 12;
            // Возвращаем подписку на событие
            checkBox_commandCode_incAddress.CheckedChanged += new System.EventHandler(this.InstructionTextBoxUpdate);
            checkBox_commandCode_rw.CheckedChanged += new System.EventHandler(this.InstructionTextBoxUpdate);
            checkBox_commandCode_verify.CheckedChanged += new System.EventHandler(this.InstructionTextBoxUpdate);
            checkBox_commandCode_reply.CheckedChanged += new System.EventHandler(this.InstructionTextBoxUpdate);
            radioButton_packetType_reply.CheckedChanged += new System.EventHandler(this.InstructionTextBoxUpdate);
            radioButton_packetType_command.CheckedChanged += new System.EventHandler(this.InstructionTextBoxUpdate);
            radioButton_replyAddrLength_0.CheckedChanged += new System.EventHandler(this.InstructionTextBoxUpdate);
            radioButton_replyAddrLength_4.CheckedChanged += new System.EventHandler(this.InstructionTextBoxUpdate);
            radioButton_replyAddrLength_8.CheckedChanged += new System.EventHandler(this.InstructionTextBoxUpdate);
            radioButton_replyAddrLength_12.CheckedChanged += new System.EventHandler(this.InstructionTextBoxUpdate);

        }

        // обновление текстбокса поля Instruction соглано текущему состоянию других элементов управления
        private void InstructionTextBoxUpdate(object sender, EventArgs e)
        {
            commandPacket.Instruction.PacketType.Command = radioButton_packetType_command.Checked && ! radioButton_packetType_reply.Checked;
            commandPacket.Instruction.PacketType.Reply = ! radioButton_packetType_command.Checked && radioButton_packetType_reply.Checked;
            commandPacket.Instruction.CommandType.WriteRead = checkBox_commandCode_rw.Checked;
            commandPacket.Instruction.CommandType.VerifyDataBeforeWrite = checkBox_commandCode_verify.Checked;
            commandPacket.Instruction.CommandType.Reply = checkBox_commandCode_reply.Checked;
            commandPacket.Instruction.CommandType.IncrementAddress = checkBox_commandCode_incAddress.Checked;
            commandPacket.Instruction.AddressLength.Set0 = radioButton_replyAddrLength_0.Checked;
            commandPacket.Instruction.AddressLength.Set4 = radioButton_replyAddrLength_4.Checked;
            commandPacket.Instruction.AddressLength.Set8 = radioButton_replyAddrLength_8.Checked;
            commandPacket.Instruction.AddressLength.Set12 = radioButton_replyAddrLength_12.Checked;
            commandPacket.Instruction.Update();

            textBox_Instruction.TextChanged -= new System.EventHandler(this.InstructionControlsUpdate);
            textBox_Instruction.Text = commandPacket.Instruction.ToString();
            textBox_Instruction.TextChanged += new System.EventHandler(this.InstructionControlsUpdate);
        }

        private void button_headerCRC_calc_Click(object sender, EventArgs e)
        {
            UpdateAllFields();
            commandPacket.UpdateHeaderCrc();
            textBox_headerCRC.Text = commandPacket.HeaderCRC.ToString();
            
        }
        private void button_daraCRC_calc_Click(object sender, EventArgs e)
        {
            UpdateAllFields();
            commandPacket.UpdateDataCrc();
            textBox_dataCRC.Text = commandPacket.DataCRC.ToString();
        }

        private void button_parsePacket_Click(object sender, EventArgs e)
        {
            Report("--- Парсинг нового пакета:  -----\r\n");
            commandPacket.TargetLogicalAddresses.Set(textBox_TargetLogicalAddresses.Text);

            if (commandPacket.TargetLogicalAddresses.Fail)
            {
                Report("Ошибка : Поле TargetLogicalAddresses заполнено не корректно");
                return;
            }


            commandPacket.Parse(textBox_packet.Text, out string log);

            Report("TargetLogicalAddresses = " + commandPacket.TargetLogicalAddresses.ToString());

            if (log != "")
            {
                Report(log);
            }
            else
            {
                UpdateAllControls();
                Report(commandPacket.Status + "\r\n");
            }
        }

        private void UpdateAllControls()
        {
            textBox_TargetSpWAddresses.Text = commandPacket.TargetSpWAddresses.ToString(" 0x","","");
            textBox_ProtocolIdentifier.Text = commandPacket.ProtocolIdentifier.ToString("0x", "");
            textBox_Instruction.Text = commandPacket.Instruction.ToString("0x", "");
            textBox_Key.Text = commandPacket.Key.ToString("0x", "");
            textBox_ReplayAddresses.Text = commandPacket.ReplyAddress.ToString(" 0x", "", "");
            textBox_InitiatorLogicalAddress.Text = commandPacket.InitiatorLogicalAddress.ToString("0x", "");
            textBox_TransactionIdentifier.Text = commandPacket.TransactionIdentifier.ToString("0x", "");
            textBox_extendedAddress.Text = commandPacket.ExtendedAddress.ToString("0x", "");
            textBox_address.Text = commandPacket.Address.ToString("0x", "");
            textBox_DataLength.Text = commandPacket.DataLength.ToString("0x", "");
            textBox_headerCRC.Text = commandPacket.HeaderCRC.ToString("0x", "");
            textBox_Data.Text = commandPacket.Data.ToString(" 0x", "", "");
            textBox_dataCRC.Text = commandPacket.DataCRC.ToString("0x", "");
            radioButton_Eep.Checked = commandPacket.EEP;
        }

    }
}
