/*
 * Created by SharpDevelop.
 * User: xe03713
 * Date: 06/08/2015
 * Time: 13:18
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.IO;
using System.Text.RegularExpressions;

namespace FileSearcher
{
	/// <summary>
	/// Description of FileTools.
	/// </summary>
	public static class FileTools
	{

		    
		public static String[] FileExtractLineas(String path, String line, int nlines)
        {
			String[] prelines = new String[nlines];
			String[] postlines = new String[nlines];
			String[] lastlines = new String[(nlines*2)+1];
        	List<string> lines = new List<string>();
        	
            using (var reader = new StreamReader(path))
            {
                try
                {
                	while(!reader.EndOfStream){
                		String liner=reader.ReadLine();
                		if (liner.Contains(line)) {
                			for (int i=nlines-1;i>=0;i--){
                				prelines[i]=lines[lines.Count-(nlines-(i+1))-1];
                				lastlines[i]=prelines[i];
                			}
                			for (int i=0;i<nlines;i++){
                				if (!reader.EndOfStream){
	                				String liner2=reader.ReadLine();
	                				postlines[i] = liner2;
	                				lastlines[nlines+1+i]=postlines[i];
                				}
                			}
                			lastlines[nlines]=liner;
                			return lastlines;
                			
                		}else{
                			lines.Add(liner);                			
                		}
                	}
                	return null;
                }
                catch (IOException ex)
                {
                	System.Diagnostics.Debug.Print(ex.Message);
                }
                
                catch (OutOfMemoryException ex)
                {
                	System.Diagnostics.Debug.Print(ex.Message);
                }
                catch (Exception ex)
                {
                	System.Diagnostics.Debug.Print(ex.Message);
                }
                return null;
            }
 
            throw new Exception("Something bad happened.");
        }
        
	}
}
