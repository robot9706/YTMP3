using System;
using System.Text;
using System.IO;
using System.IO.Compression;
using System.Collections.Generic;

namespace YoutubeMP3Downloader
{
	public class SettingsFile
	{
		private string _AppStyle = string.Empty;
		public string AppStyle
		{
			get { return _AppStyle; }
			set { _AppStyle = value;  }
		}
		
		private string _AppColorStyle = string.Empty;
		public string AppColorStyle
		{
			get { return _AppColorStyle; }
			set { _AppColorStyle = value;  }
		}
		
		private string _DownloadFolder = string.Empty;
		public string DownloadFolder
		{
			get { return _DownloadFolder; }
			set { _DownloadFolder = value;  }
		}
		
		private string _Language = string.Empty;
		public string Language
		{
			get { return _Language; }
			set { _Language = value;  }
		}
		
		
		public static SettingsFile ReadFile(string fileName)
		{
			SettingsFile file = new SettingsFile();
			file.Read(fileName);
			return file;
		}
		
		public static SettingsFile ReadFile(Stream stream)
		{
			SettingsFile file = new SettingsFile();
			file.Read(stream);
			return file;
		}
		
		public static SettingsFile ReadFile(BinaryReader reader)
		{
			SettingsFile file = new SettingsFile();
			file.Read(reader);
			return file;
		}
		
		public void Read(string fileName)
		{
			Read(File.OpenRead(fileName));
		}
		
		public void Read(Stream stream)
		{
			using (BinaryReader br = new BinaryReader(stream, Encoding.UTF8))
			{
				Read(br);
			}
		}
		
		public void Read(BinaryReader br)
		{
			_AppStyle = br.ReadString();
			_AppColorStyle = br.ReadString();
			_DownloadFolder = br.ReadString();
			_Language = br.ReadString();
		}
		
		public void Write(string fileName)
		{
			Write(new FileStream(fileName, FileMode.Create));
		}
		
		public void Write(Stream stream)
		{
			using (BinaryWriter bw = new BinaryWriter(stream, Encoding.UTF8))
			{
				Write(bw);
			}
		}
		
		public void Write(BinaryWriter bw)
		{
			bw.Write(_AppStyle);
			bw.Write(_AppColorStyle);
			bw.Write(_DownloadFolder);
			bw.Write(_Language);
		}

	}
}
