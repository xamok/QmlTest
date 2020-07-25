import QtQuick 2.12
import QtQuick.Controls 2.12
import QtQuick.Layouts 1.0
import test 1.1

ApplicationWindow {
	visible: true
	title: qsTr("hello")
	width: 640
	height: 320

	QmlType {
		id: test
	}

	Button {
		text: "press me"
		onClicked: {
			 var task = test.testAsync()
          // And we can await the task
          Net.await(task, function(result) {
              // With the result!
              console.log(result)
          })
		}
	}
}