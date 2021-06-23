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
        
        private RmapPacket currentPacket;

        public Form_main()
        {
            InitializeComponent();

            this.consoleContextMenu.Items.AddRange(new[] { clearMenuItem, copyMenuItem });
            this.copyMenuItem.Click += CopyMenuItem_Click;
            this.clearMenuItem.Click += ClearMenuItem_Click;
            this.statusMenuItem.Click += StatusMenuItem_Click;

            currentPacket = new RmapPacket();
            UpdateAllFields();
        }

        private void ClearMenuItem_Click(object sender, EventArgs e)
        {
            textBox_Console.Clear();
        }

        private void StatusMenuItem_Click(object sender, EventArgs e)
        {
            Report(currentPacket.FieldsStatus);
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
            textBox_packet.Text = currentPacket.GetRMAPPacket();
            Report("---  Создан новый пакет ---\r\n");
            Report(currentPacket.GetReport);
        }

        private void UpdateAllFields()
        {
            currentPacket.SpwAddresses.Set(textBox_TargetSpWAddresses.Text);
            currentPacket.TargetLogicalAddresses.Set(textBox_TargetLogicalAddresses.Text);
            currentPacket.ProtocolIdentifier.Set(textBox_ProtocolIdentifier.Text);
            currentPacket.Instruction.Set(textBox_Instruction.Text);
            currentPacket.Key.Set(textBox_Key.Text);
            currentPacket.ReplyAddresses.Set(textBox_ReplayAddresses.Text);
            currentPacket.InitiatorLogicalAddress.Set(textBox_InitiatorLogicalAddress.Text);
            currentPacket.TransactionIdentifier.Set(textBox_TransactionIdentifier.Text);
            currentPacket.ExtendedAddress.Set(textBox_extendedAddress.Text);
            currentPacket.Address.Set(textBox_address.Text);
            currentPacket.DataLength.Set(textBox_DataLength.Text);
            currentPacket.HeaderCRC.Set(textBox_headerCRC.Text);
            currentPacket.Data.Set(textBox_Data.Text);
            currentPacket.DataCRC.Set(textBox_dataCRC.Text);
            currentPacket.EEP = radioButton_Eep.Checked;

            if (currentPacket.Fail)
            {
                Report("одно или несколько полей заполнено не корректно");
            }
        }

        private void Report(string rep)
        {
            textBox_Console.AppendText(rep + "\r\n");

        }
        // обновление элементов управления полем "Instruction":
        private void TextBoxInstruction_Chenged(object sender, EventArgs e)
        {
            currentPacket.Instruction.Set(textBox_Instruction.Text);

            if (currentPacket.Instruction.Fail)
            {
                return;
            }

            // отписываем InstructionTextBoxUpdate от событий, чтобы не зациклиться:
            checkBox_commandCode_incAddress.CheckedChanged -= new System.EventHandler(this.InstructionControls_Chenged);
            checkBox_commandCode_rw.CheckedChanged -= new System.EventHandler(this.InstructionControls_Chenged);
            checkBox_commandCode_verify.CheckedChanged -= new System.EventHandler(this.InstructionControls_Chenged);
            checkBox_commandCode_reply.CheckedChanged -= new System.EventHandler(this.InstructionControls_Chenged);
            radioButton_packetType_reply.CheckedChanged -= new System.EventHandler(this.InstructionControls_Chenged);
            radioButton_packetType_command.CheckedChanged -= new System.EventHandler(this.InstructionControls_Chenged);
            radioButton_replyAddrLength_0.CheckedChanged -= new System.EventHandler(this.InstructionControls_Chenged);
            radioButton_replyAddrLength_4.CheckedChanged -= new System.EventHandler(this.InstructionControls_Chenged);
            radioButton_replyAddrLength_8.CheckedChanged -= new System.EventHandler(this.InstructionControls_Chenged);
            radioButton_replyAddrLength_12.CheckedChanged -= new System.EventHandler(this.InstructionControls_Chenged);
            // обновляем элементы управления
            checkBox_commandCode_rw.Checked = currentPacket.Instruction.CommandType.Write;
            checkBox_commandCode_verify.Checked = currentPacket.Instruction.CommandType.VerifyDataBeforeWrite;
            checkBox_commandCode_reply.Checked = currentPacket.Instruction.CommandType.Reply;
            checkBox_commandCode_incAddress.Checked = currentPacket.Instruction.CommandType.IncrementAddress;
            radioButton_packetType_reply.Checked = currentPacket.Instruction.PacketType.Reply;
            radioButton_packetType_command.Checked = currentPacket.Instruction.PacketType.Command;
            radioButton_replyAddrLength_0.Checked = currentPacket.Instruction.AddressLength.ToInt() == 0;
            radioButton_replyAddrLength_4.Checked = currentPacket.Instruction.AddressLength.ToInt() == 4;
            radioButton_replyAddrLength_8.Checked = currentPacket.Instruction.AddressLength.ToInt() == 8;
            radioButton_replyAddrLength_12.Checked = currentPacket.Instruction.AddressLength.ToInt() == 12;
            // Возвращаем подписку на событие
            checkBox_commandCode_incAddress.CheckedChanged += new System.EventHandler(this.InstructionControls_Chenged);
            checkBox_commandCode_rw.CheckedChanged += new System.EventHandler(this.InstructionControls_Chenged);
            checkBox_commandCode_verify.CheckedChanged += new System.EventHandler(this.InstructionControls_Chenged);
            checkBox_commandCode_reply.CheckedChanged += new System.EventHandler(this.InstructionControls_Chenged);
            radioButton_packetType_reply.CheckedChanged += new System.EventHandler(this.InstructionControls_Chenged);
            radioButton_packetType_command.CheckedChanged += new System.EventHandler(this.InstructionControls_Chenged);
            radioButton_replyAddrLength_0.CheckedChanged += new System.EventHandler(this.InstructionControls_Chenged);
            radioButton_replyAddrLength_4.CheckedChanged += new System.EventHandler(this.InstructionControls_Chenged);
            radioButton_replyAddrLength_8.CheckedChanged += new System.EventHandler(this.InstructionControls_Chenged);
            radioButton_replyAddrLength_12.CheckedChanged += new System.EventHandler(this.InstructionControls_Chenged);

            DisableUnusableControls();
        }

        // обновление текстбокса поля Instruction соглано текущему состоянию других элементов управления
        private void InstructionControls_Chenged(object sender, EventArgs e)
        {
            currentPacket.Instruction.PacketType.Command = radioButton_packetType_command.Checked && ! radioButton_packetType_reply.Checked;
            currentPacket.Instruction.PacketType.Reply = ! radioButton_packetType_command.Checked && radioButton_packetType_reply.Checked;
            currentPacket.Instruction.CommandType.Write = checkBox_commandCode_rw.Checked;
            currentPacket.Instruction.CommandType.VerifyDataBeforeWrite = checkBox_commandCode_verify.Checked;
            currentPacket.Instruction.CommandType.Reply = checkBox_commandCode_reply.Checked;
            currentPacket.Instruction.CommandType.IncrementAddress = checkBox_commandCode_incAddress.Checked;
            currentPacket.Instruction.AddressLength.Set0 = radioButton_replyAddrLength_0.Checked;
            currentPacket.Instruction.AddressLength.Set4 = radioButton_replyAddrLength_4.Checked;
            currentPacket.Instruction.AddressLength.Set8 = radioButton_replyAddrLength_8.Checked;
            currentPacket.Instruction.AddressLength.Set12 = radioButton_replyAddrLength_12.Checked;
            currentPacket.Instruction.Update();

            textBox_Instruction.TextChanged -= new System.EventHandler(this.TextBoxInstruction_Chenged);
            textBox_Instruction.Text = currentPacket.Instruction.ToString();
            textBox_Instruction.TextChanged += new System.EventHandler(this.TextBoxInstruction_Chenged);

            DisableUnusableControls();
        }
        private void DisableUnusableControls()
        {
            EnableAllControls();
            if (currentPacket.Instruction.PacketType.Command)
            {
                textBox_Status.Enabled = false;
                label_Status.Enabled = false;
            }
            if (currentPacket.Instruction.PacketType.Reply)
            {
                textBox_ReplayAddresses.Enabled = false;
                textBox_extendedAddress.Enabled = false;
                textBox_address.Enabled = false;
                textBox_Key.Enabled = false;
                label_ReplayAddress.Enabled = false;
                label_ExtendedAddress.Enabled = false;
                label_Address.Enabled = false;
                label_Key.Enabled = false;
            }
            if (!currentPacket.Instruction.DataExist)
            {
                textBox_Data.Enabled = false;
                textBox_dataCRC.Enabled = false;
                textBox_DataLength.Enabled = false;
                label_Data.Enabled = false;
                label_DataCrc.Enabled = false;
                label_DataLength.Enabled = false;
                button_daraCRC_calc.Enabled = false;
            }
        }
        private void EnableAllControls()
        {
            textBox_Status.Enabled = true;
            textBox_ReplayAddresses.Enabled = true;
            textBox_extendedAddress.Enabled = true;
            textBox_address.Enabled = true;
            textBox_Key.Enabled = true;
            textBox_Data.Enabled = true;
            textBox_dataCRC.Enabled = true;
            textBox_DataLength.Enabled = true;

            label_Status.Enabled = true;
            label_ReplayAddress.Enabled = true;
            label_ExtendedAddress.Enabled = true;
            label_Address.Enabled = true;
            label_Key.Enabled = true;
            label_Data.Enabled = true;
            label_DataCrc.Enabled = true;
            label_DataLength.Enabled = true;

            button_daraCRC_calc.Enabled = true;
        }

        private void button_headerCRC_calc_Click(object sender, EventArgs e)
        {
            UpdateAllFields();
            currentPacket.UpdateHeaderCrc();
            textBox_headerCRC.Text = currentPacket.HeaderCRC.ToString();
            
        }
        private void button_daraCRC_calc_Click(object sender, EventArgs e)
        {
            UpdateAllFields();
            currentPacket.UpdateDataCrc();
            textBox_dataCRC.Text = currentPacket.DataCRC.ToString();
        }

        private void button_parsePacket_Click(object sender, EventArgs e)
        {
            Report("--- Парсинг нового пакета:  -----\r\n");
            currentPacket.TargetLogicalAddresses.Set(textBox_TargetLogicalAddresses.Text);

            if (currentPacket.TargetLogicalAddresses.Fail)
            {
                Report("Ошибка : Поле TargetLogicalAddresses заполнено не корректно");
                return;
            }


            currentPacket.Parse(textBox_packet.Text, out string log);

            Report("TargetLogicalAddresses = " + currentPacket.TargetLogicalAddresses.ToString());

            if (log != "")
            {
                Report(log);
            }
            else
            {
                UpdateAllControls();
                Report(currentPacket.Status + "\r\n");
            }
        }

        private void UpdateAllControls()
        {
            textBox_TargetSpWAddresses.Text = currentPacket.SpwAddresses.ToString(" 0x","","");
            textBox_ProtocolIdentifier.Text = currentPacket.ProtocolIdentifier.ToString("0x", "");
            textBox_Instruction.Text = currentPacket.Instruction.ToString("0x", "");
            textBox_Key.Text = currentPacket.Key.ToString("0x", "");
            textBox_ReplayAddresses.Text = currentPacket.ReplyAddresses.ToString(" 0x", "", "");
            textBox_InitiatorLogicalAddress.Text = currentPacket.InitiatorLogicalAddress.ToString("0x", "");
            textBox_TransactionIdentifier.Text = currentPacket.TransactionIdentifier.ToString("0x", "");
            textBox_extendedAddress.Text = currentPacket.ExtendedAddress.ToString("0x", "");
            textBox_address.Text = currentPacket.Address.ToString("0x", "");
            textBox_DataLength.Text = currentPacket.DataLength.ToString("0x", "");
            textBox_headerCRC.Text = currentPacket.HeaderCRC.ToString("0x", "");
            textBox_Data.Text = currentPacket.Data.ToString(" 0x", "", "");
            textBox_dataCRC.Text = currentPacket.DataCRC.ToString("0x", "");
            radioButton_Eep.Checked = currentPacket.EEP;
        }

    }
}
