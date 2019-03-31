﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.36392
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleCllient.BookServiceRef {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Books", Namespace="http://schemas.datacontract.org/2004/07/WcfModel")]
    [System.SerializableAttribute()]
    public partial class Books : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AuthorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CategoryIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ClicksField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ContentDescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ISBNField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime PublishDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PublisherIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TOCField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TitleField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal UnitPriceField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Author {
            get {
                return this.AuthorField;
            }
            set {
                if ((object.ReferenceEquals(this.AuthorField, value) != true)) {
                    this.AuthorField = value;
                    this.RaisePropertyChanged("Author");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CategoryId {
            get {
                return this.CategoryIdField;
            }
            set {
                if ((this.CategoryIdField.Equals(value) != true)) {
                    this.CategoryIdField = value;
                    this.RaisePropertyChanged("CategoryId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Clicks {
            get {
                return this.ClicksField;
            }
            set {
                if ((this.ClicksField.Equals(value) != true)) {
                    this.ClicksField = value;
                    this.RaisePropertyChanged("Clicks");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ContentDescription {
            get {
                return this.ContentDescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.ContentDescriptionField, value) != true)) {
                    this.ContentDescriptionField = value;
                    this.RaisePropertyChanged("ContentDescription");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ISBN {
            get {
                return this.ISBNField;
            }
            set {
                if ((object.ReferenceEquals(this.ISBNField, value) != true)) {
                    this.ISBNField = value;
                    this.RaisePropertyChanged("ISBN");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime PublishDate {
            get {
                return this.PublishDateField;
            }
            set {
                if ((this.PublishDateField.Equals(value) != true)) {
                    this.PublishDateField = value;
                    this.RaisePropertyChanged("PublishDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int PublisherId {
            get {
                return this.PublisherIdField;
            }
            set {
                if ((this.PublisherIdField.Equals(value) != true)) {
                    this.PublisherIdField = value;
                    this.RaisePropertyChanged("PublisherId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TOC {
            get {
                return this.TOCField;
            }
            set {
                if ((object.ReferenceEquals(this.TOCField, value) != true)) {
                    this.TOCField = value;
                    this.RaisePropertyChanged("TOC");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Title {
            get {
                return this.TitleField;
            }
            set {
                if ((object.ReferenceEquals(this.TitleField, value) != true)) {
                    this.TitleField = value;
                    this.RaisePropertyChanged("Title");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal UnitPrice {
            get {
                return this.UnitPriceField;
            }
            set {
                if ((this.UnitPriceField.Equals(value) != true)) {
                    this.UnitPriceField = value;
                    this.RaisePropertyChanged("UnitPrice");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="BookServiceRef.IBookService")]
    public interface IBookService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookService/GetBook", ReplyAction="http://tempuri.org/IBookService/GetBookResponse")]
        string GetBook(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookService/GetBook", ReplyAction="http://tempuri.org/IBookService/GetBookResponse")]
        System.Threading.Tasks.Task<string> GetBookAsync(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookService/GetList", ReplyAction="http://tempuri.org/IBookService/GetListResponse")]
        string GetList();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookService/GetList", ReplyAction="http://tempuri.org/IBookService/GetListResponse")]
        System.Threading.Tasks.Task<string> GetListAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookService/AddBook", ReplyAction="http://tempuri.org/IBookService/AddBookResponse")]
        string AddBook(ConsoleCllient.BookServiceRef.Books books);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookService/AddBook", ReplyAction="http://tempuri.org/IBookService/AddBookResponse")]
        System.Threading.Tasks.Task<string> AddBookAsync(ConsoleCllient.BookServiceRef.Books books);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookService/delBook", ReplyAction="http://tempuri.org/IBookService/delBookResponse")]
        string delBook(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookService/delBook", ReplyAction="http://tempuri.org/IBookService/delBookResponse")]
        System.Threading.Tasks.Task<string> delBookAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookService/editBook", ReplyAction="http://tempuri.org/IBookService/editBookResponse")]
        string editBook(ConsoleCllient.BookServiceRef.Books books);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookService/editBook", ReplyAction="http://tempuri.org/IBookService/editBookResponse")]
        System.Threading.Tasks.Task<string> editBookAsync(ConsoleCllient.BookServiceRef.Books books);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookService/calculate", ReplyAction="http://tempuri.org/IBookService/calculateResponse")]
        int calculate(int x, int y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookService/calculate", ReplyAction="http://tempuri.org/IBookService/calculateResponse")]
        System.Threading.Tasks.Task<int> calculateAsync(int x, int y);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IBookServiceChannel : ConsoleCllient.BookServiceRef.IBookService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class BookServiceClient : System.ServiceModel.ClientBase<ConsoleCllient.BookServiceRef.IBookService>, ConsoleCllient.BookServiceRef.IBookService {
        
        public BookServiceClient() {
        }
        
        public BookServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public BookServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BookServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BookServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetBook(string id) {
            return base.Channel.GetBook(id);
        }
        
        public System.Threading.Tasks.Task<string> GetBookAsync(string id) {
            return base.Channel.GetBookAsync(id);
        }
        
        public string GetList() {
            return base.Channel.GetList();
        }
        
        public System.Threading.Tasks.Task<string> GetListAsync() {
            return base.Channel.GetListAsync();
        }
        
        public string AddBook(ConsoleCllient.BookServiceRef.Books books) {
            return base.Channel.AddBook(books);
        }
        
        public System.Threading.Tasks.Task<string> AddBookAsync(ConsoleCllient.BookServiceRef.Books books) {
            return base.Channel.AddBookAsync(books);
        }
        
        public string delBook(int id) {
            return base.Channel.delBook(id);
        }
        
        public System.Threading.Tasks.Task<string> delBookAsync(int id) {
            return base.Channel.delBookAsync(id);
        }
        
        public string editBook(ConsoleCllient.BookServiceRef.Books books) {
            return base.Channel.editBook(books);
        }
        
        public System.Threading.Tasks.Task<string> editBookAsync(ConsoleCllient.BookServiceRef.Books books) {
            return base.Channel.editBookAsync(books);
        }
        
        public int calculate(int x, int y) {
            return base.Channel.calculate(x, y);
        }
        
        public System.Threading.Tasks.Task<int> calculateAsync(int x, int y) {
            return base.Channel.calculateAsync(x, y);
        }
    }
}
