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
    public partial class Form1 : Form
    {
        
        private WritePacket writeCommand;

        public Form1()
        {
            InitializeComponent();

            this.consoleContextMenu.Items.AddRange(new[] { clearMenuItem, copyMenuItem });


            writeCommand = new WritePacket();
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

            textBox_packet.Text = writeCommand.GetRMAPPacket();
            Report(writeCommand.Status + "\r\n");
        }

        private void UpdateAllFields()
        {
            writeCommand.TargetSpWAddresses.Set(textBox_TargetSpWAddresses.Text);
            writeCommand.TargetLogicalAddresses.Set(textBox_TargetLogicalAddresses.Text);
            writeCommand.ProtocolIdentifier.Set(textBox_ProtocolIdentifier.Text);
            writeCommand.Instruction.Set(textBox_Instruction.Text);
            writeCommand.Key.Set(textBox_Key.Text);
            writeCommand.ReplyAddress.Set(textBox_ReplayAddresses.Text);
            writeCommand.InitiatorLogicalAddress.Set(textBox_InitiatorLogicalAddress.Text);
            writeCommand.TransactionIdentifier.Set(textBox_TransactionIdentifier.Text);
            writeCommand.ExtendedAddress.Set(textBox_extendedAddress.Text);
            writeCommand.Address.Set(textBox_address.Text);
            writeCommand.DataLength.Set(textBox_DataLength.Text);
            writeCommand.HeaderCRC.Set(textBox_headerCRC.Text);
            writeCommand.Data.Set(textBox_Data.Text);
            writeCommand.DataCRC.Set(textBox_dataCRC.Text);
            writeCommand.EEP = radioButton_Eep.Checked;

            if (writeCommand.Fail)
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
            writeCommand.Instruction.Set(textBox_Instruction.Text);

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
            checkBox_commandCode_rw.Checked = writeCommand.Instruction.CommandType.WriteRead;
            checkBox_commandCode_verify.Checked = writeCommand.Instruction.CommandType.VerifyDataBeforeWrite;
            checkBox_commandCode_reply.Checked = writeCommand.Instruction.CommandType.Reply;
            checkBox_commandCode_incAddress.Checked = writeCommand.Instruction.CommandType.IncrementAddress;
            radioButton_packetType_reply.Checked = writeCommand.Instruction.PacketType.Reply;
            radioButton_packetType_command.Checked = writeCommand.Instruction.PacketType.Command;
            radioButton_replyAddrLength_0.Checked = writeCommand.Instruction.AddressLength.ToInt() == 0;
            radioButton_replyAddrLength_4.Checked = writeCommand.Instruction.AddressLength.ToInt() == 4;
            radioButton_replyAddrLength_8.Checked = writeCommand.Instruction.AddressLength.ToInt() == 8;
            radioButton_replyAddrLength_12.Checked = writeCommand.Instruction.AddressLength.ToInt() == 12;
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
            writeCommand.Instruction.PacketType.Command = radioButton_packetType_command.Checked && ! radioButton_packetType_reply.Checked;
            writeCommand.Instruction.PacketType.Reply = ! radioButton_packetType_command.Checked && radioButton_packetType_reply.Checked;
            writeCommand.Instruction.CommandType.WriteRead = checkBox_commandCode_rw.Checked;
            writeCommand.Instruction.CommandType.VerifyDataBeforeWrite = checkBox_commandCode_verify.Checked;
            writeCommand.Instruction.CommandType.Reply = checkBox_commandCode_reply.Checked;
            writeCommand.Instruction.CommandType.IncrementAddress = checkBox_commandCode_incAddress.Checked;
            writeCommand.Instruction.AddressLength.Set0 = radioButton_replyAddrLength_0.Checked;
            writeCommand.Instruction.AddressLength.Set4 = radioButton_replyAddrLength_4.Checked;
            writeCommand.Instruction.AddressLength.Set8 = radioButton_replyAddrLength_8.Checked;
            writeCommand.Instruction.AddressLength.Set12 = radioButton_replyAddrLength_12.Checked;
            writeCommand.Instruction.Update();

            textBox_Instruction.TextChanged -= new System.EventHandler(this.InstructionControlsUpdate);
            textBox_Instruction.Text = writeCommand.Instruction.ToString();
            textBox_Instruction.TextChanged += new System.EventHandler(this.InstructionControlsUpdate);
        }

        private void button_headerCRC_calc_Click(object sender, EventArgs e)
        {
            UpdateAllFields();
            writeCommand.UpdateHeaderCrc();
            textBox_headerCRC.Text = writeCommand.HeaderCRC.ToString(" 0x");
        }
        private void button_daraCRC_calc_Click(object sender, EventArgs e)
        {
            UpdateAllFields();
            writeCommand.UpdateDataCrc();
            textBox_dataCRC.Text = writeCommand.DataCRC.ToString(" 0x");
        }

        private void button_parsePacket_Click(object sender, EventArgs e)
        {

        }
    }
}
