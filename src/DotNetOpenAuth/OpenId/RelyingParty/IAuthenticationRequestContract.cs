﻿// <auto-generated />

namespace DotNetOpenAuth.OpenId.RelyingParty {
	using System;
	using System.Collections.Generic;
	using System.Diagnostics.Contracts;
	using System.Linq;
	using System.Text;
	using DotNetOpenAuth.Messaging;
	using DotNetOpenAuth.OpenId.Messages;

	[ContractClassFor(typeof(IAuthenticationRequest))]
	internal abstract class IAuthenticationRequestContract : IAuthenticationRequest {
		#region IAuthenticationRequest Members

		AuthenticationRequestMode IAuthenticationRequest.Mode {
			get {
				throw new NotImplementedException();
			}

			set {
				throw new NotImplementedException();
			}
		}

		OutgoingWebResponse IAuthenticationRequest.RedirectingResponse {
			get { throw new NotImplementedException(); }
		}

		Uri IAuthenticationRequest.ReturnToUrl {
			get { throw new NotImplementedException(); }
		}

		Realm IAuthenticationRequest.Realm {
			get { throw new NotImplementedException(); }
		}

		Identifier IAuthenticationRequest.ClaimedIdentifier {
			get { throw new NotImplementedException(); }
		}

		bool IAuthenticationRequest.IsDirectedIdentity {
			get { throw new NotImplementedException(); }
		}

		bool IAuthenticationRequest.IsExtensionOnly {
			get {
				throw new NotImplementedException();
			}

			set {
				throw new NotImplementedException();
			}
		}

		IProviderEndpoint IAuthenticationRequest.Provider {
			get { throw new NotImplementedException(); }
		}

		void IAuthenticationRequest.AddCallbackArguments(IDictionary<string, string> arguments) {
			Contract.Requires<ArgumentNullException>(arguments != null);
			Contract.Requires<ArgumentException>(arguments.Keys.All(k => !String.IsNullOrEmpty(k)));
			Contract.Requires<ArgumentException>(arguments.Values.All(v => v != null));
			throw new NotImplementedException();
		}

		void IAuthenticationRequest.AddCallbackArguments(string key, string value) {
			Contract.Requires<ArgumentException>(!String.IsNullOrEmpty(key));
			Contract.Requires<ArgumentNullException>(value != null);
			throw new NotImplementedException();
		}

		void IAuthenticationRequest.AddExtension(IOpenIdMessageExtension extension) {
			Contract.Requires<ArgumentNullException>(extension != null);
			throw new NotImplementedException();
		}

		void IAuthenticationRequest.RedirectToProvider() {
			throw new NotImplementedException();
		}

		#endregion
	}
}
