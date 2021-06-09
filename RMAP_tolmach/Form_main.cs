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
        
        private WritePacket writePacket;

        public Form_main()
        {
            InitializeComponent();

            this.consoleContextMenu.Items.AddRange(new[] { clearMenuItem, copyMenuItem });
            


            writePacket = new WritePacket();
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

            textBox_packet.Text = writePacket.GetRMAPPacket(" ");
            Report("---  Создан новый пакет ---\r\n");
            Report(writePacket.Status + "\r\n");
        }

        private void UpdateAllFields()
        {
            writePacket.TargetSpWAddresses.Set(textBox_TargetSpWAddresses.Text);
            writePacket.TargetLogicalAddresses.Set(textBox_TargetLogicalAddresses.Text);
            writePacket.ProtocolIdentifier.Set(textBox_ProtocolIdentifier.Text);
            writePacket.Instruction.Set(textBox_Instruction.Text);
            writePacket.Key.Set(textBox_Key.Text);
            writePacket.ReplyAddress.Set(textBox_ReplayAddresses.Text);
            writePacket.InitiatorLogicalAddress.Set(textBox_InitiatorLogicalAddress.Text);
            writePacket.TransactionIdentifier.Set(textBox_TransactionIdentifier.Text);
            writePacket.ExtendedAddress.Set(textBox_extendedAddress.Text);
            writePacket.Address.Set(textBox_address.Text);
            writePacket.DataLength.Set(textBox_DataLength.Text);
            writePacket.HeaderCRC.Set(textBox_headerCRC.Text);
            writePacket.Data.Set(textBox_Data.Text);
            writePacket.DataCRC.Set(textBox_dataCRC.Text);
            writePacket.EEP = radioButton_Eep.Checked;

            if (writePacket.Fail)
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
            writePacket.Instruction.Set(textBox_Instruction.Text);

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
            checkBox_commandCode_rw.Checked = writePacket.Instruction.CommandType.WriteRead;
            checkBox_commandCode_verify.Checked = writePacket.Instruction.CommandType.VerifyDataBeforeWrite;
            checkBox_commandCode_reply.Checked = writePacket.Instruction.CommandType.Reply;
            checkBox_commandCode_incAddress.Checked = writePacket.Instruction.CommandType.IncrementAddress;
            radioButton_packetType_reply.Checked = writePacket.Instruction.PacketType.Reply;
            radioButton_packetType_command.Checked = writePacket.Instruction.PacketType.Command;
            radioButton_replyAddrLength_0.Checked = writePacket.Instruction.AddressLength.ToInt() == 0;
            radioButton_replyAddrLength_4.Checked = writePacket.Instruction.AddressLength.ToInt() == 4;
            radioButton_replyAddrLength_8.Checked = writePacket.Instruction.AddressLength.ToInt() == 8;
            radioButton_replyAddrLength_12.Checked = writePacket.Instruction.AddressLength.ToInt() == 12;
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
            writePacket.Instruction.PacketType.Command = radioButton_packetType_command.Checked && ! radioButton_packetType_reply.Checked;
            writePacket.Instruction.PacketType.Reply = ! radioButton_packetType_command.Checked && radioButton_packetType_reply.Checked;
            writePacket.Instruction.CommandType.WriteRead = checkBox_commandCode_rw.Checked;
            writePacket.Instruction.CommandType.VerifyDataBeforeWrite = checkBox_commandCode_verify.Checked;
            writePacket.Instruction.CommandType.Reply = checkBox_commandCode_reply.Checked;
            writePacket.Instruction.CommandType.IncrementAddress = checkBox_commandCode_incAddress.Checked;
            writePacket.Instruction.AddressLength.Set0 = radioButton_replyAddrLength_0.Checked;
            writePacket.Instruction.AddressLength.Set4 = radioButton_replyAddrLength_4.Checked;
            writePacket.Instruction.AddressLength.Set8 = radioButton_replyAddrLength_8.Checked;
            writePacket.Instruction.AddressLength.Set12 = radioButton_replyAddrLength_12.Checked;
            writePacket.Instruction.Update();

            textBox_Instruction.TextChanged -= new System.EventHandler(this.InstructionControlsUpdate);
            textBox_Instruction.Text = writePacket.Instruction.ToString();
            textBox_Instruction.TextChanged += new System.EventHandler(this.InstructionControlsUpdate);
        }

        private void button_headerCRC_calc_Click(object sender, EventArgs e)
        {
            UpdateAllFields();

            /*
            // вывод хедера:
            string text = "";
            for (int i = 0; i < writePacket.Header.Length; i++)
            {

                text += writePacket.Header[i].ToString("X2") + " ";
            }
            Report(text);
            */
            
            writePacket.UpdateHeaderCrc();
            textBox_headerCRC.Text = writePacket.HeaderCRC.ToString(" 0x");
            
        }
        private void button_daraCRC_calc_Click(object sender, EventArgs e)
        {
            UpdateAllFields();
            writePacket.UpdateDataCrc();
            textBox_dataCRC.Text = writePacket.DataCRC.ToString(" 0x");
        }

        private void button_parsePacket_Click(object sender, EventArgs e)
        {
            Report("--- Расшифровка нового пакета:  -----\r\n");
            writePacket.TargetLogicalAddresses.Set(textBox_TargetLogicalAddresses.Text);

            if (writePacket.TargetLogicalAddresses.Fail)
            {
                Report("Ошибка : Поле TargetLogicalAddresses заполнено не корректно");
                return;
            }

            writePacket.Parse(textBox_packet.Text);


            textBox_TargetSpWAddresses.Text = writePacket.TargetSpWAddresses.ToString();
            textBox_ProtocolIdentifier.Text = writePacket.ProtocolIdentifier.ToString();
            textBox_Instruction.Text = writePacket.Instruction.ToString();
            textBox_Key.Text = writePacket.Key.ToString();
            textBox_ReplayAddresses.Text = writePacket.ReplyAddress.ToString();
            textBox_InitiatorLogicalAddress.Text = writePacket.InitiatorLogicalAddress.ToString();
            textBox_TransactionIdentifier.Text = writePacket.TransactionIdentifier.ToString();
            textBox_extendedAddress.Text = writePacket.ExtendedAddress.ToString();
            textBox_address.Text = writePacket.Address.ToString();
            textBox_DataLength.Text = writePacket.DataLength.ToString();
            textBox_headerCRC.Text = writePacket.HeaderCRC.ToString();
            textBox_Data.Text = writePacket.Data.ToString();
            textBox_dataCRC.Text = writePacket.DataCRC.ToString();
            radioButton_Eep.Checked = writePacket.EEP;

            Report(writePacket.Status + "\r\n");
        }
    }
}
