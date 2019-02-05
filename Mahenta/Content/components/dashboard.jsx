import { Component, Fragment } from 'react';
import { Helmet } from 'react-helmet';

export class Dashboard extends Component {
	render() {
		return (
			<div className="dashboardMain">
				<Helmet>
					<title>Mahenta</title>
				</Helmet>
				<h1>About Mahenta</h1>
				<h2>Mission</h2>
				<p>To Cceate a scalable and optimal solution for nonprofits who otherwise cannot afford the resources it takes to develop and maintain internal tools. Mahenta is an open source template solution that will provide a basic foundation that is easy to setup, straightforward UX design and abstracted enough to fill the needs of different nonprofits</p>
				<h2>Technologies:</h2>
				<p>Mahenta is built on a mixed stack, with a React.js frontend and a Asp.Net Core C# backend. It utilizes SQL and is designed to easily be deployed through Microsoft’s Azure. Additional services include Azure Blob Storage for data such as pictures, audio and other various raw binary data, Azure Key Vaults for secure environment variables and packages such as Identity for user management and Entity Framework Core.</p>
			</div>
		);
	}
}
