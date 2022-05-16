import ('System.IO')

function remove_text_bin(path, mod)
	textFullPath  = path .. "\\" .. mod .. "data\\text"
	directoryInfo = DirectoryInfo(textFullPath)
	for fl in directoryInfo.GetFiles() do
		extension = fl.Extension;
		if(extension == ".bin") then
			File.Delete(fl.FullName)
		end
	end
end