import { Component, Fragment } from 'react';
import { Helmet } from 'react-helmet';

export class Dashboard extends Component {
	render() {
		return (
			<Fragment>
				<Helmet>
					<title>ReactJS.NET Demos</title>
				</Helmet>
				<h1
					style={{
						lineHeight: '2',
						color: '#222',
						fontFamily: 'Helvetica, sans-serif',
						textShadow: '0 0 5px lightgray',
					}}
				>
					ReactJS.NET is 🔥🔥
				</h1>
			</Fragment>
		);
	}
}
