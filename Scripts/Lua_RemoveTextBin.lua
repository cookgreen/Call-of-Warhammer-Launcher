import ('System')
import ('System.IO')

function remove_text_bin(path, mod)
	textFullPath  = path .. "\\mods\\" .. mod .. "\\data\\text"
	directoryInfo = DirectoryInfo(textFullPath)
	local arr = directoryInfo:GetFiles();
	for i=1, arr.Length do
		local fl = arr[i - 1]
		
		if(fl.Extension == ".bin") then
			File.Delete(fl.FullName)
		end
	end
end