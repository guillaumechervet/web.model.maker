using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Antlr.Runtime;
using Antlr4.StringTemplate;
using Antlr4.StringTemplate.Compiler;
using Antlr4.StringTemplate.Extensions;
using Antlr4.StringTemplate.Misc;

namespace ConsoleApplication1
{
    public class TemplateGroupCustom : TemplateGroupFile
    {
        public TemplateGroupCustom(string fileName) : base(fileName)
        {
        }

        public TemplateGroupCustom(string fileName, char delimiterStartChar, char delimiterStopChar) : base(fileName, delimiterStartChar, delimiterStopChar)
        {
        }

        public TemplateGroupCustom(string fullyQualifiedFileName, Encoding encoding) : base(fullyQualifiedFileName, encoding)
        {
        }

        public TemplateGroupCustom(string fullyQualifiedFileName, Encoding encoding, char delimiterStartChar, char delimiterStopChar) : base(fullyQualifiedFileName, encoding, delimiterStartChar, delimiterStopChar)
        {
        }

        public TemplateGroupCustom(Uri url, Encoding encoding, char delimiterStartChar, char delimiterStopChar) : base(url, encoding, delimiterStartChar, delimiterStopChar)
        {
        }

        public override Antlr4.StringTemplate.Compiler.CompiledTemplate Compile(string srcName, string name, List<Antlr4.StringTemplate.Compiler.FormalArgument> args, string template, Antlr.Runtime.IToken templateToken)
        {
            return base.Compile(srcName, name, args, template, templateToken);
        }


        public override Template CreateSingleton(Antlr.Runtime.IToken templateToken)
        {
            return base.CreateSingleton(templateToken);
        }

        public override Template CreateStringTemplate()
        {
            return base.CreateStringTemplate();
        }

        public override Template CreateStringTemplate(Antlr4.StringTemplate.Compiler.CompiledTemplate impl)
        {
            return base.CreateStringTemplate(impl);
        }

        public override void DefineDictionary(string name, IDictionary<string, object> mapping)
        {
            base.DefineDictionary(name, mapping);
        }

        public override Antlr4.StringTemplate.Compiler.CompiledTemplate DefineRegion(string enclosingTemplateName, Antlr.Runtime.IToken regionT, string template, Antlr.Runtime.IToken templateToken)
        {
            return base.DefineRegion(enclosingTemplateName, regionT, template, templateToken);
        }

        public override Antlr4.StringTemplate.Compiler.CompiledTemplate DefineTemplate(string fullyQualifiedTemplateName, Antlr.Runtime.IToken nameT, List<Antlr4.StringTemplate.Compiler.FormalArgument> args, string template, Antlr.Runtime.IToken templateToken)
        {
            return base.DefineTemplate(fullyQualifiedTemplateName, nameT, args, template, templateToken);
        }

        public override Antlr4.StringTemplate.Compiler.CompiledTemplate DefineTemplate(string name, string template)
        {
            return base.DefineTemplate(name, template);
        }

        public override Antlr4.StringTemplate.Compiler.CompiledTemplate DefineTemplate(string name, string template, string[] arguments)
        {
            return base.DefineTemplate(name, template, arguments);
        }

        public override Antlr4.StringTemplate.Compiler.CompiledTemplate DefineTemplateAlias(Antlr.Runtime.IToken aliasT, Antlr.Runtime.IToken targetT)
        {
            return base.DefineTemplateAlias(aliasT, targetT);
        }

        public override void DefineTemplateOrRegion(string fullyQualifiedTemplateName, string regionSurroundingTemplateName, Antlr.Runtime.IToken templateToken, string template, Antlr.Runtime.IToken nameToken, List<Antlr4.StringTemplate.Compiler.FormalArgument> args)
        {
            base.DefineTemplateOrRegion(fullyQualifiedTemplateName, regionSurroundingTemplateName, templateToken, template, nameToken, args);
        }

        public override IAttributeRenderer GetAttributeRenderer(Type attributeType)
        {
            return base.GetAttributeRenderer(attributeType);
        }

        protected override Template GetEmbeddedInstanceOf(TemplateFrame frame, string name)
        {
                return base.GetEmbeddedInstanceOf(frame, name);
        }

        public override Template GetInstanceOf(string name)
        {
            return base.GetInstanceOf(name);
        }

        public override IModelAdaptor GetModelAdaptor(Type attributeType)
        {
            return base.GetModelAdaptor(attributeType);
        }

        public override ITypeProxyFactory GetTypeProxyFactory(Type targetType)
        {
            return base.GetTypeProxyFactory(targetType);
        }

        public override void ImportTemplates(Antlr.Runtime.IToken fileNameToken)
        {
            base.ImportTemplates(fileNameToken);
        }

        public override void ImportTemplates(TemplateGroup g)
        {
            base.ImportTemplates(g);
        }

        public override bool IsDefined(string name)
        {
            return base.IsDefined(name);
        }

        public override bool IsDictionary(string name)
        {
            return base.IsDictionary(name);
        }

        public override ITemplateErrorListener Listener
        {
            get
            {
                return base.Listener;
            }
            set
            {
                base.Listener = value;
            }
        }

        public override void Load()
        {
            base.Load();
        }

        protected override Antlr4.StringTemplate.Compiler.CompiledTemplate Load(string name)
        {
            return base.Load(name);
        }


        public override Antlr4.StringTemplate.Compiler.CompiledTemplate LoadAbsoluteTemplateFile(string fileName)
        {
            ANTLRFileStream antlrFileStream;
            try
            {
                antlrFileStream = new ANTLRFileStream(fileName, this.Encoding);
                antlrFileStream.name = fileName;
            }
            catch (IOException ex)
            {
                return (CompiledTemplate)null;
            }
           return this.LoadTemplateFile("", fileName, (ICharStream)antlrFileStream);
            return base.LoadAbsoluteTemplateFile(fileName);
        }

        public override void LoadGroupFile(string prefix, string fileName)
        {
            try
            {
                ANTLRReaderStream antlrReaderStream = new ANTLRReaderStream((TextReader)new StreamReader(new Uri(fileName).LocalPath, this.Encoding));
                GroupLexer groupLexer = new GroupLexer((ICharStream)antlrReaderStream);
                antlrReaderStream.name = fileName;
                new GroupParser((ITokenStream)new CommonTokenStream((ITokenSource)groupLexer)).group(this, prefix);
            }
            catch (Exception ex)
            {
                ExceptionExtensions.PreserveStackTrace(ex);
                if (!ExceptionExtensions.IsCritical(ex))
                    this.ErrorManager.IOError((Template)null, ErrorType.CANT_LOAD_GROUP_FILE, ex, (object)fileName);
                throw;
            }
            base.LoadGroupFile(prefix, fileName);
        }

        protected override Antlr4.StringTemplate.Compiler.CompiledTemplate LookupImportedTemplate(string name)
        {
            return base.LookupImportedTemplate(name);
        }

        public override Antlr4.StringTemplate.Compiler.CompiledTemplate LookupTemplate(string name)
        {
            return base.LookupTemplate(name);
        }

        public override string Name
        {
            get
            {
                return base.Name;
            }
        }

        public override void RawDefineTemplate(string name, Antlr4.StringTemplate.Compiler.CompiledTemplate code, Antlr.Runtime.IToken defT)
        {
            base.RawDefineTemplate(name, code, defT);
        }

        public override IDictionary<string, object> RawGetDictionary(string name)
        {
            return base.RawGetDictionary(name);
        }

        public override Antlr4.StringTemplate.Compiler.CompiledTemplate RawGetTemplate(string name)
        {
            return base.RawGetTemplate(name);
        }

        public override void RegisterModelAdaptor(Type attributeType, IModelAdaptor adaptor)
        {
            base.RegisterModelAdaptor(attributeType, adaptor);
        }

        public override void RegisterRenderer(Type attributeType, IAttributeRenderer renderer, bool recursive)
        {
            base.RegisterRenderer(attributeType, renderer, recursive);
        }

        public override void RegisterTypeProxyFactory(Type targetType, ITypeProxyFactory factory)
        {
            base.RegisterTypeProxyFactory(targetType, factory);
        }

        public override void SetDelimiters(Antlr.Runtime.IToken openDelimiter, Antlr.Runtime.IToken closeDelimiter)
        {
            base.SetDelimiters(openDelimiter, closeDelimiter);
        }

        public override void SetDelimiters(char delimiterStartChar, char delimiterStopChar)
        {
            base.SetDelimiters(delimiterStartChar, delimiterStopChar);
        }

        public override void UndefineTemplate(string name)
        {
            base.UndefineTemplate(name);
        }

        public override Uri RootDirUri
        {
            get
            {
                return base.RootDirUri;
            }
        }

        public override string FileName
        {
            get
            {
                return base.FileName;
            }
        }


    }
}
